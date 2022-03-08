string fileName = @"checksum - input.txt";

using (StreamReader reader = File.OpenText(fileName))
{
    string text = reader.ReadToEnd();
    Console.WriteLine(Checksum.ChecksumChecker.ChecksumResult(text).ToString());
    Console.WriteLine(Checksum.ChecksumChecker.ChecksumResult(text, (text.Length / 2)).ToString());
}
