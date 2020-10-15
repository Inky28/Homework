/*
 Створити класи для Агенції Розважальних Заходів
--------------------------------------------------
Клієнт(Client) 	
	ім'я	
	номер телефону
Визначити конструктор(и) та  властивості для полів класу
*Перевіряти правильність телефону
Перевизначити(override) метод  ToString()


Захід(Event)
	назва
	кількість осіб заходу
	місце проведення
	час проведення(стандартна структура DateTime)
	ІД події(автоматично присвоюється 1, 2, 3, ...), формується на основі статичного поля counter
	counter - статичне поле, що рахує кількість створених екземплярів 
	клієнт(посилання на Клієнта, що замовив захід)
Методи 
	конструктор(и)
	перенесення події на певне число днів вперед( метод AddDay структури DateTime )
https://docs.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=netframework-4.8
	перенесення події на певне число тижнів вперед
	
Визначити  властивості для полів класу. 
*Перевіряти правильність дати події( не раніше сьогоднішньої), властивості DateTime.Today, DateTime.Now
Перевизначити(override) метод  ToString()

EventService
	список запланованих(замовлених) заходів, List<Event>
Методи
	додавання події до списку подій
	видалення події
	очищення списку подій(Clear)
	пошук(вивід) подій замовлених на певну дату
	пошук(вивід) подій замовлених на певний діапазон дат(дати можна порівнювати операціями >, <, методом CompareTo)
	пошук(вивід) подій замовлених певним клієнтом

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04
{
    class Program
    {
        class Client
        {
            private string name;
            private string number;

            public string Name { get => name; set => name = value; }
            public string Number
            {
                get => number;

                set
                {
                    for (char i = 'a', j = 'A'; i <= 'z'; i++, j++)
                    {
                        if (value.Contains(i) || value.Contains(j))
                            return;
                    }

                    number = value;
                }
            }

            public Client(string name, string number)
            {
                Name = name;
                Number = number;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is Client))
                    return false;

                var client = obj as Client;
                return client.Name == Name && client.Number == Number;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return $"Name: {Name}: {Number}";
            }
        }
        class Event
        {
            public string Name { get; set; }
            public string Place { get; set; }
            public DateTime Time { get; set; }
            public List<Client> Clients { get; set; }

            public Event(string name, string place, List<Client> clients, DateTime time = new DateTime())
            {
                Name = name;
                Place = place;

                if (time >= DateTime.Today)
                    Time = time;
                else
                    Time = DateTime.Today;

                if (clients == null)
                    Clients = new List<Client>();
                else
                    Clients = clients;
            }

            public void PostponeDays(int days)
            {
                Time.AddDays(days);
            }

            public void PostponeWeeks(int weeks)
            {
                Time.AddDays(weeks * 7);
            }

            public override string ToString()
            {
                return $"Event: {Name}, place: {Place}";
            }
        }
        class EventService
        {
            public List<Event> Events { get; set; }

            public EventService()
            {
                Events = new List<Event>();
            }

            public void AddEvent(Event e)
            {
                Events.Add(e);
            }

            public void DelEvent(Event e)
            {
                Events.Remove(e);
            }

            public void ClearEvents()
            {
                Events.Clear();
            }

            public void FindEvent(DateTime date)
            {
                var events = Events.FindAll(x => x.Time.Equals(date));
                events.ForEach(x => Console.WriteLine(x));
            }

            public void FindEventsInRange(DateTime leftBorder, DateTime rigthBorder)
            {
                var events = Events.FindAll(x => x.Time >= leftBorder || x.Time <= rigthBorder);
                events.ForEach(x => Console.WriteLine(x));
            }

            public void FindByClient(Client client)
            {
                var events = Events.FindAll(x => x.Clients.Contains(client));
                events.ForEach(x => Console.WriteLine(x));
            }
        }
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>()
            {
                new Client("Client1", "1"),
                new Client("Client2", "2")
            };

            EventService eventService = new EventService()
            {
                Events = new List<Event>()
                    {
                        new Event("Event1", "Place1", clients),
                        new Event("Event2", "Place2", clients, DateTime.Today.AddDays(1)),
                    }
            };

            eventService.FindEvent(DateTime.Today.AddDays(1));
            Console.WriteLine();

            eventService.FindEventsInRange(DateTime.Today.AddDays(1), DateTime.Today.AddDays(5));
            Console.WriteLine();

            eventService.FindByClient(clients[0]);
        }
    }
}
