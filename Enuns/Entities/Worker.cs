using System.Diagnostics.Contracts;
using Enuns.Entities.Enuns;
namespace Enuns.Entities{
    class Worker{
        public string Name { get; set; }
        public workerLevel Level {get; set;}
        public double  BaseSalary { get; set; }
        public Departament Departament {get; set;}

        public List<HoursContracts> Contracts {get; set;} = new List<HoursContracts>(); // garante  que a lista não seja nula 

        public Worker(){

        }

        public Worker(string name, workerLevel level, double basesalary, Departament departament){
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Departament = departament;

        }
        public void AddContract(HoursContracts contracts){
            Contracts.Add(contracts);
        }
        public void RemoverContract(HoursContracts contracts){
            Contracts.Remove(contracts);
        }
        public double Income(int year, int month){
            double sum = BaseSalary;
            foreach(HoursContracts item in Contracts){
                if(item.Date.Year == year && item.Date.Month == month){
                    sum += item.TotalValue();
                }
            }
            return sum;
        }
    }
}