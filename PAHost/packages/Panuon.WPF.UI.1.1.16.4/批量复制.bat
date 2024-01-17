copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Core31\netcoreapp3.1\Panuon.WPF.UI.dll" "lib\netcoreapp3.1"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Core31\netcoreapp3.1\Panuon.WPF.UI.pdb" "lib\netcoreapp3.1"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\netcoreapp3.1\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net5\net5.0-windows\Panuon.WPF.UI.dll" "lib\net5.0-windows"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net5\net5.0-windows\Panuon.WPF.UI.pdb" "lib\net5.0-windows"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net5.0-windows\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net6\net6.0-windows\Panuon.WPF.UI.dll" "lib\net6.0-windows"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net6\net6.0-windows\Panuon.WPF.UI.pdb" "lib\net6.0-windows"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net6.0-windows\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net7\net7.0-windows\Panuon.WPF.UI.dll" "lib\net7.0-windows"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net7\net7.0-windows\Panuon.WPF.UI.pdb" "lib\net7.0-windows"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net7.0-windows\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net45\Panuon.WPF.UI.dll" "lib\net45"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net45\Panuon.WPF.UI.pdb" "lib\net45"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net45\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net462\Panuon.WPF.UI.dll" "lib\net462"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net462\Panuon.WPF.UI.pdb" "lib\net462"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net462\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net472\Panuon.WPF.UI.dll" "lib\net472"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net472\Panuon.WPF.UI.pdb" "lib\net472"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net472\Panuon.WPF.UI.dll"

copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net48\Panuon.WPF.UI.dll" "lib\net48"
copy "D:\GitHub\PanuonGroup\Panuon.WPF.UI\SourceCode\Outputs\Release\Net48\Panuon.WPF.UI.pdb" "lib\net48"
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /n "Shanghai Banyue Computer Network Co., Ltd." /t "http://timestamp.digicert.com" "lib\net48\Panuon.WPF.UI.dll"

nuget pack

pause