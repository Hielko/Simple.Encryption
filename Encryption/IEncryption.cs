﻿namespace Hielko.Encryption
{
    public interface IEncryption
    {
        string? Decrypt(string? plaintext);
        string? Encrypt(string? plaintext);
    }
}