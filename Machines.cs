using System;

public abstract class BaseMachine
{
    public DateTime ProductDate { get; set; }
    public int SerialNumber { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public string ProductOs { get; set; }

    public BaseMachine()
    {
        ProductDate = DateTime.Now;
    }

    public virtual void Details()
    {
        Console.WriteLine($"Üretim Tarihi: {ProductDate}");
        Console.WriteLine($"Seri Numarası: {SerialNumber}");
        Console.WriteLine($"Ürün Adı: {ProductName}");
        Console.WriteLine($"Açıklama: {ProductDescription}");
        Console.WriteLine($"İşletim Sistemi: {ProductOs}");
    }

    public BaseMachine(int serialNumber, string productName, string productDescription, string productOs)
    {
        ProductDate = DateTime.Now;
        SerialNumber = serialNumber;
        ProductName = productName;
        ProductDescription = productDescription;
        ProductOs = productOs;
    }


    public abstract void PrintProductName();
}

public class Phone : BaseMachine
{
    public string TrLicence { get; set; }

    public override void Details()
    {
        base.Details();
        if (!string.IsNullOrEmpty(TrLicence))
        {
            Console.WriteLine($"Tr Lisansı: {TrLicence}");
        }
        else
        {
            Console.WriteLine("Lisans bulunmamakta");
        }
    }

    public Phone(int serialNumber, string productName, string productDescription, string productOs, string trLicence)
    : base(serialNumber, productName, productDescription, productOs)
    {
        TrLicence = trLicence;
    }

    public override void PrintProductName()
    {
        Console.WriteLine($"Telefonunuzun adı: {ProductName}");
    }
}

public class Computer : BaseMachine
{
    private int _usbAmount { get; set; }
    private bool _bluetooth { get; set; }

    public int UsbAmount
    {
        get { return _usbAmount; }
        set
        {
            if (value == 2 || value == 4)
                _usbAmount = value;
            else
            {
                Console.WriteLine("USB giriş sayısı 2 veya 4 olmalıdır. Varsayılan olarak -1 atanıyor.");
                _usbAmount = -1;
            }
        }
    }

    public Computer(int serialNumber, string productName, string productDescription, string productOs, int usbAmount, bool bluetooth)
       : base(serialNumber, productName, productDescription, productOs)
    {
        UsbAmount = usbAmount;
        Bluetooth = bluetooth;
    }


    public bool Bluetooth
    {
        get { return _bluetooth; }
        set { _bluetooth = value; }
    }
    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Usb giriş sayısı {UsbAmount}");
        Console.WriteLine(Bluetooth ? "Bluetooth bulunmakta" : "Bluetooth mevcut değil");
    }

    public override void PrintProductName()
    {
        Console.WriteLine($"Bilgisayarınızın adı {ProductName}");
    }
}