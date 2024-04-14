# PgenV2

Secure password generator coded with C# and Windows Forms and it uses **_Membership.GeneratePassword(Int32, Int32)_** Method of **_System.Web assembly_**.

This method guarantees that the gnerated passwords are always unique.

This method uses the following special characters **_ !@#$%^&*()_-+=[{]};:<>|./? _** but due to most websites doesn not allow some of them such as **_.:_;_**  the application will automatically replace them with other mostly allowed characters.


![pgenv2.gif](https://github.com/IT-Support-L2/PgenV2/blob/master/pgenv2.gif)
