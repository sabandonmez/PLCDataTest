using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ModbusConnectDto
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public byte SlaveId { get; set; }
        public ushort DataAddress { get; set; } // 0 - 65535 arasında bir değer
        public ushort DataSize { get; set; } // Veri boyutu
        public string WriteValue { get; set; } // Yazma işlemi için kullanılacak değer
        public string ReadValue { get; set; } // Okuma işlemi sonucunda döndürülecek değer
    }
}
