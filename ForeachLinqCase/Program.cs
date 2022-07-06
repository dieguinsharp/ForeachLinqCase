using System;
using System.Collections.Generic;
using System.Linq;

namespace ForeachLinqCase {
    internal class Program {
        static void Main (string[] args) {
            var kpis = RepoKPI.GetKPIValues().ToList();

            // show only kpi value's bigger then 100

            kpis.ForEach(kpi => { 

                if(kpi.Value > 100) {
                    Console.WriteLine(kpi.Value);
                }

            });

            Console.WriteLine();
            Console.WriteLine(" Next case ");
            Console.WriteLine();

            // show only kpi value's less then 100

            kpis.ForEach(kpi => { 

                if(kpi.Value < 100) {
                    Console.WriteLine(kpi.Value);
                }

            });

            Console.WriteLine();
            Console.WriteLine(" Next case ");
            Console.WriteLine();

            // show only kpi value's bigger 100 and less then 300

            kpis.ForEach(kpi => { 

                if(kpi.Value > 100 && kpi.Value < 300) {
                    Console.WriteLine(kpi.Value);
                }

            });

            Console.WriteLine();
            Console.WriteLine(" Next case ");
            Console.WriteLine();

            // set values in kpi value's (samething the 'foreach')

            kpis.ForEach(kpi => {

                if(kpi.Value < 100)
                    kpi.Value = 100;

                if(kpi.Value > 1000)
                    kpi.Value = 0;   

            });

            kpis.ForEach(kpi => Console.WriteLine(kpi.Value));

        }
    }

    public class RepoKPI {
        public static IEnumerable<KPIValue> GetKPIValues () {

            var items = new List<KPIValue>();

            for(int x = 0;x < 100;x++) {
                items.Add(new KPIValue("Coil", (x * 1.6f)* x/2 ));
            }

            return items;
        }
    }

    public class KPIValue {
        public string Name { get; set; }
        public float Value { get; set; }

        public KPIValue(string name, float value) {
            Name = name;
            Value = value;
        }

        public KPIValue () {

        }
    }
}
