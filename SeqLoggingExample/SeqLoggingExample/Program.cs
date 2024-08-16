using Serilog;

class Program
{
    static void Main(string[] args)
    {
        // SEQ serverinə bağlanmaq üçün Serilog konfiqurasiyasını yaradın
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Seq("http://localhost:5341") // SEQ serverin URL adresi
            .CreateLogger();

        // Fərqli log səviyyələrində mesajlar yazın
        Log.Information("Bu bir məlumat mesajıdır.");
        Log.Warning("Bu bir xəbərdarlıq mesajıdır.");
        Log.Error("Bu bir səhv mesajıdır.");

        // Log məlumatlarını yumaq və sistemi təmizləmək üçün
        Log.CloseAndFlush();
    }
}
