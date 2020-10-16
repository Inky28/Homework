using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp comp = new Comp();
            Menu menu = new Menu();


            menu.Add(new MenuItem("Add disk", () => {

                var menu1 = new Menu();

                menu1.Add(new MenuItem("CD", () => comp.AddDisc(new CD())));
                menu1.Add(new MenuItem("Flash", () => comp.AddDisc(new Flash())));
                menu1.Add(new MenuItem("HDD", () => comp.AddDisc(new HDD())));
                menu1.Add(new MenuItem("DVD", () => comp.AddDisc(new DVD())));

                menu1.Add(new MenuItem("Exit", () => menu1.Exit()));
                menu1.Start();
            }));

            menu.Add(new MenuItem("Add print device", () =>
            {
                var menu1 = new Menu();

                menu1.Add(new MenuItem("Monitor", () => comp.AddDevice(new Monitor())));
                menu1.Add(new MenuItem("Printer", () => comp.AddDevice(new Printer())));
                menu1.Add(new MenuItem("Exit", () => menu1.Exit()));

                menu1.Start();
            }));

            menu.Add(new MenuItem("Show disk", () => {
                comp.ShowDisk();
                System.Threading.Thread.Sleep(2000);
            }));

            menu.Add(new MenuItem("Show print device", () => {
                comp.ShowPrintDevice();
                System.Threading.Thread.Sleep(2000);
            }));

            menu.Add(new MenuItem("Exit", () => menu.Exit()));

            menu.Start();
        }
    }
}
