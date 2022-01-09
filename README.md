
# South-African-ID-Validation

<img src ="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/.NET_Logo.svg/2048px-.NET_Logo.svg.png" height=100px>

<img src ="https://upload.wikimedia.org/wikipedia/commons/e/e6/ZA_Smart_ID_Front.png" height=100px>


just an app written in `ASP.NET Razor Pages` experimenting with the framework

## Web Routes

`GET /validateid/<idnumber>`

Function coded in C#. (Could of done it in `JavaScript`) from the top of my head just was thinking for a quick project to do to see what ASP.NET is all about.

## Regex for South African ID Numbers Validation

### Regex used in function

```
(((\d{2}((0[13578]|1[02])(0[1-9]|[12]\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\d|30)|02(0[1-9]|1\d|2[0-8])))|([02468][048]|[13579][26])0229))(( |-)(\d{4})( |-)(\d{3})|(\d{7}))
```
