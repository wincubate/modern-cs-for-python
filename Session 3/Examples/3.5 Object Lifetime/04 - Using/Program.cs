using (DataWriter dataWriter = new())
{
    Console.WriteLine("Writing byte...");
    dataWriter.Write();
} // <-- Dispose()

class DataWriter : IDisposable
{  
    private FileStream _fs;

    public DataWriter()
    {
        string path = @"C:\Tmp\Test.txt";
        _fs = File.OpenWrite(path);
    }

    public void Write()
    {
        byte toBeWritten = 65; // 'A'
        _fs.Write([toBeWritten], 0, 1);
        _fs.Flush();
    }

    public void Dispose()
    {
        _fs.Dispose();
    }
}
