namespace Entities.Models
{
   public class SiemensOperationModel
   {
     public string IpAddress { get; set; }
    public int Rack { get; set; }
    public int Slot { get; set; }
    public int CpuType { get; set; }
    public ushort DataAddress { get; set; } // 0 - 65535 arasında bir değer
    public ushort DataSize { get; set; } // Veri boyutu
    public string DataSorting { get; set; }
    public string DataType { get; set; }
    public string DbAddress { get; set; } // Veri bloğu adresi
    public int StartAddress { get; set; } // Başlangıç adresi
    public int CharacterCount { get; set; }
    public int Port { get; set; }
    public string WriteValue { get; set; } // Yazma işlemi için kullanılacak değer
    public string ReadValue { get; set; } // Okuma işlemi sonucunda döndürülecek değer
   }

}