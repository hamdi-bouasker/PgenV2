# PgenV2

Secure password generator coded with C# and Windows Forms and it uses Membership.GeneratePassword(Int32, Int32) Method of System.Web assembly.

This method guarantees that the gnerated passwords are always unique.

This method uses the following special characters !@#$%^&*()_-+=[{]};:<>|./? but due to most websites doesn not allow some of them such as .:;_  the application will replace them with other mostly allowed characters.
