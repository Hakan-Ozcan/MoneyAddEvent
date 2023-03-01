
using System.ComponentModel;
class Banka : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private double para;

    public double Para
    {
        get
        {
            return para;
        }
        set
        {
            para = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Para)));
            }
        }
    }

    
}
class Program
{
    static void Main(string[] args)
    {
        Banka banka = new Banka();
        banka.PropertyChanged += Banka_PropertyChanged;
        banka.Para += 100;
    

        Console.Read();
    }

    private static void Banka_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        Console.WriteLine("Para eklendi");
    }
    private static void Banka_PropertyChanged2(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        Console.WriteLine("Para çıkarıldı");
    }
}