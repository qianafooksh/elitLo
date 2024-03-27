try
{
    // Code that might throw a CryptographicException
}
catch (CryptographicException e)
{
    Console.WriteLine("A cryptographic error occurred: " + e.Message);
    // Additional error handling
}
