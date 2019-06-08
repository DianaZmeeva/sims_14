using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_14
{
    public class AgentClass
    {
        private bool buzy;
        private double nowTime, workTime;
        private double l, min, max;
        private int n;
        private FlowLayoutPanel flowpanel_agent;
        private Label label;

        public AgentClass(int i, double lambda, FlowLayoutPanel f)
        {
            buzy = false;
            workTime = 0;
            l = lambda;
            n = i;
            flowpanel_agent = f;

            label = new Label
            {
                Text = $"Менеджер {n + 1} свободен",
                Width = 70,
                Height = 70,
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            flowpanel_agent.Controls.Add(label);
        }

        public void TimerTick(double now)
        {
            if (buzy)
            {
                nowTime = now;
                if (nowTime - workTime >= 0)
                {
                    buzy = false;
                    label.Text = $"Менеджер {n + 1} свободен";
                }
                else
                {
                    label.Text = $"Менеджер {n + 1} занят {Math.Round((Math.Abs(workTime-nowTime)),1)}";
                }
            }
        }

        public void Work(double n)
        {
            nowTime = n;
            buzy = true;
            DistributionClass ex = new DistributionClass();
            double t1 = ex.exp(l);
            double t2 = ex.exp(l);
            if (t1 > t2)
            {
                min = t2;
                max = t1;
            }
            else
            {
                min = t1;
                max = t2;
            }

            workTime = Math.Round((ex.uniform(min, max)), 1);
            if (workTime < 0.1)
                workTime += 0.2;
            workTime += nowTime;

        }

        public bool AgentFree()
        {
            return !buzy;
        }
    }
}
