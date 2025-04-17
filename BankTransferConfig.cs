using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300041
{
    internal class BankTransferConfig
    {
        public String lang { get; set; }
        public class Transfer() {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }
        public Transfer transfer { get; set; }

        public List<String> methods { get; set; }
        public class Confirmation
        {
            public String en { get; set; }
            public String id { get; set; }
        }
        public Confirmation confirmation { get; set; }

        public const String filePath = "D:\\Adrian\\modul8_103022300041\\bank_transfer_config.json";
      
        public BankTransferConfig ReadConfigFile()
        {
            String jsonString = File.ReadAllText(@"bank_transfer_config.json");
            BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
            return config;
        }
        
    }
}
