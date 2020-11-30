# Hash Libraries
Hello, you can make easier hash calculations using the Simplified Hash Library.

> **Note:** We recommend that you do not include the System.Security.Cryptography library in your project when using libraries.

## How do I use it?
First download the files, then import the downloaded files into your project.
Or you can directly view the files as Raw and copy them to your project.
### Example Usage
Example uses are as follows.
Don't forget to add the hashlibs library to your project.
```
using hashlibs;
```
##### MD5:
```
MD5 md5 = new MD5();
string a = md5.Create("Hello World");
MessageBox.Show("MD5:" + a);
```
##### MD5 File Fingerprint:
```
MD5 md5 = new MD5();
string a = md5.FileFingerprint(@"C:\folder\file.exe");
MessageBox.Show("MD5:" + a);
```
It's that simple.
The uses of **SHA1**, **SHA256**, **SHA384** and **SHA512** are like the examples above.
