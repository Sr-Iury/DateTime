using System.Globalization;
public class Program
{
    static void Main(string[] args)
    {
        DateTime data = new DateTime(2023, 07, 26);//estancia da classe DateTime, e passando parametros dos metodos.
        DateTime data2 = new DateTime(2007, 04, 28);
        TimeSpan ts = data.Subtract(data2);
        Console.WriteLine(ts.Days);
        DateOnly dol = new DateOnly(2023, 07, 26);
        Console.WriteLine(dol);
        int difuDatas = DateTime.Compare(data, data2);
        Console.WriteLine(difuDatas);
        int dif = data.CompareTo(data2); 
        /*DateTime dataVencimento = data.AddDays(2);
        DateTime HORArond = Convert.ToDateTime(DateTime.UtcNow);
        DateTime hora = HORArond.AddHours(-4);*/

        /*Console.WriteLine(data.Year);//To.String Faz por na sua ordem.
       Console.WriteLine(data.DayOfYear);//To.String Faz por na sua ordem.
       Console.WriteLine(DateTime.UtcNow.Hour);
       Console.WriteLine(data.ToString("ddd", new CultureInfo("br-pt")));
       DateTime HORArond = Convert.ToDateTime(DateTime.UtcNow.Hour);
       DateTime total = HORAron - 



      Console.Write("Informe sua data de nascimento: ");
       DateTime dataNas = DateTime.Parse("1995/08/23");
       Console.WriteLine(dataNas);*/
    }
}


