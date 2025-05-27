# Description
This is the NET 8 version of the Simple.Encryption package 
This service for MVC allows you to encrypt and decrypt strings with a configurable key.


# Installation
Install the package via NuGet:
```code
Install-Package Simple.Encryption

In the startup.cs add:
    services.AddSimpleEncryption(_config);
```

# Configuration
The EXAMPLE configuration below can be added to the appsettings:
```
  "Simple": {
    "Encryption": {
      "Key": "A546C4DF2A8CF5931469B24222322301"
    }
  }
```


# Create Key
Use this for example:
https://cloud.google.com/network-connectivity/docs/vpn/how-to/generating-pre-shared-key


# Usage
```
public class ClassTest
    {
        private readonly IEncryption _encryption;

        public ClassTest(IEncryption encryption)  {
            _encryption = encryption;
        }

        public void Test() {
           string plainValue = "ABCD";
           var encryptedValue = _encryption?.Encrypt(plainValue);
        }
    }
```
