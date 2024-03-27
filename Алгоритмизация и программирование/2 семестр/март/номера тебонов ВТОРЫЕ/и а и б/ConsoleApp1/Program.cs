using CallRecordsAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CallRecordsAnalyzer
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<CallRecord> callRecords = GetCallRecordsFromUser();

            // Для хранения частых звонков по номерам и датам
            Dictionary<string, Dictionary<string, int>> callsCounter = new Dictionary<string, Dictionary<string, int>>();

            // Для хранения длительности разговоров по номерам и датам
            Dictionary<string, Dictionary<string, int>> durationCounter = new Dictionary<string, Dictionary<string, int>>();

            foreach (var record in callRecords)
            {
                // Обработка части а)
                if (!callsCounter.ContainsKey(record.CallDate))
                {
                    callsCounter[record.CallDate] = new Dictionary<string, int>();
                }

                string keyCalls = record.CallerPhoneNumber;
                if (callsCounter[record.CallDate].ContainsKey(keyCalls))
                {
                    callsCounter[record.CallDate][keyCalls]++;
                }
                else
                {
                    callsCounter[record.CallDate][keyCalls] = 1;
                }

                // Обработка части б)
                if (!durationCounter.ContainsKey(record.CallDate))
                {
                    durationCounter[record.CallDate] = new Dictionary<string, int>();
                }

                string keyDuration = record.CallerPhoneNumber;
                if (durationCounter[record.CallDate].ContainsKey(keyDuration))
                {
                    durationCounter[record.CallDate][keyDuration] += record.Duration;
                }
                else
                {
                    durationCounter[record.CallDate][keyDuration] = record.Duration;
                }
            }

            // Вывод результатов для части а)
            foreach (var dateEntry in callsCounter)
            {
                int maxCalls = 0;
                string mostCalledNumber = "";
                foreach (var callCount in dateEntry.Value)
                {
                    if (callCount.Value > maxCalls)
                    {
                        maxCalls = callCount.Value;
                        mostCalledNumber = callCount.Key;
                    }
                }

                Console.WriteLine($"Частый звонок. Дата: {dateEntry.Key}, Номер: {mostCalledNumber}");
            }

            // Вывод результатов для части б)
            foreach (var dateEntry in durationCounter)
            {
                int maxDuration = 0;
                string mostTalkedNumber = "";
                foreach (var durationCount in dateEntry.Value)
                {
                    if (durationCount.Value > maxDuration)
                    {
                        maxDuration = durationCount.Value;
                        mostTalkedNumber = durationCount.Key;
                    }
                }

                Console.WriteLine($"Долгий разговор. Дата: {dateEntry.Key}, Номер: {mostTalkedNumber}, Длительность: {maxDuration} минут");
            }
            Console.ReadKey();
        }

        static List<CallRecord> GetCallRecordsFromUser()
        {
            List<CallRecord> callRecords = new List<CallRecord>
        {
            new CallRecord { CallerPhoneNumber = "123456789", CalledPhoneNumber = "555555555", CallDate = "01012000", Duration = 10 },
            new CallRecord { CallerPhoneNumber = "123456789", CalledPhoneNumber = "555555555", CallDate = "01012000", Duration = 5 },
            new CallRecord { CallerPhoneNumber = "123456789", CalledPhoneNumber = "555555555", CallDate = "02012000", Duration = 5 },
            new CallRecord { CallerPhoneNumber = "987654321", CalledPhoneNumber = "123456789", CallDate = "02012000", Duration = 15 }
        };

            return callRecords;
        }
    }

    class CallRecord
    {
        public
        string CallerPhoneNumber { get; set; }
        public string CalledPhoneNumber { get; set; }
        public string CallDate { get; set; }
        public int Duration { get; set; }
    }

}
