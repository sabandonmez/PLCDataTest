namespace Entities.Models
{
    public class ModbusOperationModel
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public byte SlaveId { get; set; } // Modbus adresleme 0-255 arası
        public ushort DataAddress { get; set; } // 0 - 65535 arasında bir değer
        public string DataType { get; set; }
        public string DataSorting { get; set; } // Veri Sıralaması BigEndian veya LittleEndian iki seçenek arasında seçim yaparız
        public ushort DataSize { get; set; } // Veri boyutu
        public string WriteValue { get; set; } // Yazma işlemi için kullanılacak değer
        public string ReadValue { get; set; } // Okuma işlemi sonucunda döndürülecek değer
        public bool Connection{get;set;}
    }
}