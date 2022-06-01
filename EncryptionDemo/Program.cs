using System.Security.Cryptography;
using NETCore.Encrypt;

Console.WriteLine("Base 64 Encryption");

var srcString = "base64 string";
var hashed = EncryptProvider.Base64Encrypt(srcString);   //default encoding is UTF-8

Console.WriteLine("Hashed Value: {0}", hashed);

var strValue = EncryptProvider.Base64Decrypt(hashed);   //default encoding is UTF-8

Console.WriteLine("Value: {0}", strValue);

Console.WriteLine("RSA Encryption");

var rsaKey = EncryptProvider.CreateRsaKey(RsaSize.R4096);    //default is 2048

var publicKey = rsaKey.PublicKey;
var privateKey = rsaKey.PrivateKey;

Console.WriteLine("Public Key: {0}", publicKey);
Console.WriteLine("Private Key: {0}", privateKey);

// On mac/linux at version 2.0.5
var rsaEncrypted = EncryptProvider.RSAEncrypt(publicKey, srcString, RSAEncryptionPadding.Pkcs1);

Console.WriteLine("RSA Encrypted Value: {0}", rsaEncrypted);

// On mac/linux at version 2.0.5
var decrypted = EncryptProvider.RSADecrypt(privateKey, rsaEncrypted, RSAEncryptionPadding.Pkcs1);

Console.WriteLine("RSA Decrypted Value: {0}", decrypted);

Console.WriteLine("Done");
