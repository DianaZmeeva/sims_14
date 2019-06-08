using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_14
{
    public class ManagerClass
    {
        private List<AgentClass> agents = new List<AgentClass>();
        private Queue<CustomerClass> customers = new Queue<CustomerClass>();
        private CustomerClass customer = new CustomerClass();
        private Label Lcustomers, Loperators, LnextTime;
        private FlowLayoutPanel flowpanel_agent;
        private int agentNum=2;
        private double lambda = 2.0;
        private double now, next;
        private int a_p = 1, b_p = 2;

        public ManagerClass(Label c, Label o, Label n, FlowLayoutPanel fl)
        {
            Lcustomers = c;
            Loperators = o;
            LnextTime = n;
            flowpanel_agent = fl;

            for (int i = 0; i < agentNum; i++)
            {
                AgentClass a= new AgentClass(i, lambda, flowpanel_agent);
                agents.Add(a);
            }

            customer.GetTime(a_p, b_p, 0);
        }


        public void TimerTick(double n)
        {
            int managers = 0;
            now = n;
            if (customer.IsArrive(n))
            {
                customers.Enqueue(customer);
                customer.GetTime(a_p, b_p, n);
            }

            foreach (var a in agents)
            {
                if (a.AgentFree())
                {
                    if (customers.Count > 0)
                    {
                        customers.Dequeue();
                        a.Work(now);
                    }
                }
                if (!a.AgentFree())
                {
                    managers++;
                }
                a.TimerTick(n);
            }

            Lcustomers.Text = "Количество клиентов в очереди: " + customers.Count;
            Loperators.Text = "Количество занятых операторов: " + managers;
            LnextTime.Text = "Next event: " + customer.timearrive;
        }
    }
}
