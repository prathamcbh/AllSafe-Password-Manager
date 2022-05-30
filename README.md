# AllSafe Password Manager
People tend to reuse the passwords, where if one sign-in gets compromised, other passwords too get compromised. It also helps to remember multiple passwords with a single master password.

## Why AllSafe Password Manager?
AllSafe Password manager, provides a secure to the application by creating a **Recovery string** which the user securly stores it. If the user forgets the master password, the recovery key is written which in-turn allows the user to create a new password.

## Installation
- Install VB.net from Microsoft's website
- Clone this repo to a local directory
`
Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
`

To the cloned directory, for example if the cloned directory is `C:\AllSafe Password Manager\`, change it to

`
Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AllSafe Password Manager\Database1.mdf;Integrated Security=True")
`
