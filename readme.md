#Omschrijving
Dit is de .NET6 versie van de Hielko.Encryption package
Met deze service kan je strings encrypten en decrypten met een key die configureerbaar is.

#Installatie
Installeer de package via NuGet:
```code
Install-Package Hielko.Encryption

In je startup.cs toevoegen:
    services.AddHielkoEncryption(_config);
```

#Configuratie
De onderstaande VOORBEELD configuratie kan toegevoegd aan de appsettings:
```
  "Hielko": {
    "Encryption": {
      "Key": "A546C4DF2A8CF5931469B24222322301"
    }
  }
```


#Key maken
Kan bijvoorbeeld met deze tool:
https://cloud.google.com/network-connectivity/docs/vpn/how-to/generating-pre-shared-key


#Voorbeeld gebruik
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
