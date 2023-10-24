;#DropDB CalvinoXAFEasyTest

#Application CalvinoXAFWin
#Application CalvinoXAFWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef CalvinoXAFWin

*Action About...
 
*Action OK

#EndIf

#IfDef CalvinoXAFWeb
*Action Navigation(My Details)
#EndIf
