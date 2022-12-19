# BatchObfuscator
Simple obfuscator for batch scripts

> **⚠ The project is currently on hold.**

I take no responsibility for how this program is used. My hope is that others see it as a good tool to use and perhaps add more stuff to it.

## Features
### Randomize variables and subroutines names
![](https://github.com/guillaC/BatchObfuscator/blob/main/Randomize%20variable%20and%20subroutine%20names.png?raw=true)
### Custom substrings encoding
![](https://github.com/guillaC/BatchObfuscator/blob/main/Encode%20substrings%20by%20custom%20variables.png?raw=true)
### Obfuscate Flow
![](https://github.com/guillaC/BatchObfuscator/blob/main/Obfuscate%20Flow.png?raw=true)
### Remove comments
## Example
original : 
```batch
@echo off
SET URL=https://umod.org/games/rust/download
SET FILE="./%RANDOM%.zip"
SET FOLDERPATH="C:\Users\Guillaume\Desktop\RustServer\common\rust_dedicated\data\Managed"
ECHO Downloading from %URL%
powershell.exe -c "(New-Object Net.WebClient).DownloadFile('%URL%','%FILE%')"
ECHO Done.
ECHO Extract to current folder
powershell.exe -c "Expand-Archive -Force '%FILE%' ./"
ECHO Done.
ECHO Copy to %FOLDERPATH%.
COPY .\RustDedicated_Data\Managed\* %FOLDERPATH% /Y
COPY .\RustDedicated_Data\Managed\x64\* %FOLDERPATH%\x64\ /Y
COPY .\RustDedicated_Data\Managed\x86\* %FOLDERPATH%\x86\ /Y
ECHO Done.
pause
```
ofbuscated : 
```batch
SET 贝斯尔斯贝色贝斯爱阿=sKCnjqmoPSMJlkXFvxIgYpDRdcVNhuwQfaLGryeTEUAtHiOBzbZW
SET 饿阿艾艾艾尔豆克埃豆=xIXeZSdvAoOgDQKbrwWphTyzVUPjtCkGMJHRfuYsmqNanEciLFlB
@%饿阿艾艾艾尔豆克埃豆:~3,1%%饿阿艾艾艾尔豆克埃豆:~46,1%%饿阿艾艾艾尔豆克埃豆:~20,1%%饿阿艾艾艾尔豆克埃豆:~9,1% %饿阿艾艾艾尔豆克埃豆:~9,1%%饿阿艾艾艾尔豆克埃豆:~36,1%%饿阿艾艾艾尔豆克埃豆:~36,1%
cls
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 贝阿德尔埃贝阿贝斯爱 
:耻尔德色斯耻埃德贝耻
SET 饿艾贝维色艾色饿贝克=RfvbGnJLZgSKiPczNtoWIMHuqplBAsOEFYkxmyXVeQjrwCThUDad
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 尔埃阿克阿阿耻维阿爱 
:阿艾贝贝阿豆色克阿饿
SET 豆豆尔饿色德饿阿阿埃=aJwbietSzLNvPDnICoqYcxudlFOQMrTUjAfyKpHGshWZgBmXVRkE
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 克艾埃艾贝阿克阿维维 
:贝豆爱维艾饿色色爱饿
SET 饿维贝耻艾贝埃斯爱埃=IyhlmENbGvJkXfuzRwVrDStPWaTqUKCxeFYcAZLdnHsBogpMiOjQ
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 阿色艾埃豆贝克贝贝贝 
:尔埃阿克阿阿耻维阿爱
SET 爱艾贝德豆色克埃贝德=YwsPbznSkFdKLthXQTNqMVHyZErIvCWuapRgJDloxejGOiUcBfAm
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 贝豆爱维艾饿色色爱饿 
:贝阿德尔埃贝阿贝斯爱
SET 艾贝爱尔阿阿尔豆耻维=GrMCmovQzuAckqENalUXKyYVnDpsRwjTefxLBtJObiWPIZSHdFgh
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 耻尔德色斯耻埃德贝耻 
:阿色艾埃豆贝克贝贝贝
SET 斯豆贝饿尔尔豆耻色贝=wrfWEcOHudYsRNjtFnezPAJgBQmISxopUlaiXbZTMKyqkCVvDhLG
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 阿艾贝贝阿豆色克阿饿 
:色爱贝色耻艾克贝爱埃
SET 饿维尔贝爱饿饿艾尔艾=fcMrVUTLwalPJDxmIXRsYCQEiWzGAoKSveZFhtujkBOgyqHNdnbp
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 饿埃埃贝维克贝艾爱艾 
:克艾埃艾贝阿克阿维维
SET 斯色贝克贝贝维耻斯尔=jLXsOEBVgveTtkDrQzGyFpIMoHZwdlPchURiuabSxKAfNmqJnWYC
%饿阿艾艾艾尔豆克埃豆:~31,1%%饿阿艾艾艾尔豆克埃豆:~10,1%%饿阿艾艾艾尔豆克埃豆:~21,1%%饿阿艾艾艾尔豆克埃豆:~10,1% 色爱贝色耻艾克贝爱埃 
:饿埃埃贝维克贝艾爱艾
SET 爱爱贝埃尔尔贝埃尔尔=https://%豆豆尔饿色德饿阿阿埃:~22,1%%豆豆尔饿色德饿阿阿埃:~46,1%%豆豆尔饿色德饿阿阿埃:~17,1%%豆豆尔饿色德饿阿阿埃:~23,1%.%豆豆尔饿色德饿阿阿埃:~17,1%%豆豆尔饿色德饿阿阿埃:~29,1%%豆豆尔饿色德饿阿阿埃:~44,1%/%饿维贝耻艾贝埃斯爱埃:~45,1%%饿维贝耻艾贝埃斯爱埃:~25,1%%饿维贝耻艾贝埃斯爱埃:~4,1%%饿维贝耻艾贝埃斯爱埃:~32,1%%饿维贝耻艾贝埃斯爱埃:~42,1%/rust/%爱艾贝德豆色克埃贝德:~10,1%%爱艾贝德豆色克埃贝德:~39,1%%爱艾贝德豆色克埃贝德:~1,1%%爱艾贝德豆色克埃贝德:~6,1%%爱艾贝德豆色克埃贝德:~38,1%%爱艾贝德豆色克埃贝德:~39,1%%爱艾贝德豆色克埃贝德:~32,1%%爱艾贝德豆色克埃贝德:~10,1%
SET 阿爱饿爱饿贝贝克贝耻="./%RANDOM%.%斯豆贝饿尔尔豆耻色贝:~19,1%%斯豆贝饿尔尔豆耻色贝:~35,1%%斯豆贝饿尔尔豆耻色贝:~31,1%"
SET 维艾维克维贝豆豆阿德="C:\%贝斯尔斯贝色贝斯爱阿:~41,1%%贝斯尔斯贝色贝斯爱阿:~0,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~36,1%%贝斯尔斯贝色贝斯爱阿:~0,1%\%贝斯尔斯贝色贝斯爱阿:~35,1%%贝斯尔斯贝色贝斯爱阿:~29,1%%贝斯尔斯贝色贝斯爱阿:~45,1%%贝斯尔斯贝色贝斯爱阿:~12,1%%贝斯尔斯贝色贝斯爱阿:~12,1%%贝斯尔斯贝色贝斯爱阿:~33,1%%贝斯尔斯贝色贝斯爱阿:~29,1%%贝斯尔斯贝色贝斯爱阿:~6,1%%贝斯尔斯贝色贝斯爱阿:~38,1%\%贝斯尔斯贝色贝斯爱阿:~22,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~0,1%%贝斯尔斯贝色贝斯爱阿:~13,1%%贝斯尔斯贝色贝斯爱阿:~43,1%%贝斯尔斯贝色贝斯爱阿:~7,1%%贝斯尔斯贝色贝斯爱阿:~21,1%\%贝斯尔斯贝色贝斯爱阿:~23,1%%贝斯尔斯贝色贝斯爱阿:~29,1%%贝斯尔斯贝色贝斯爱阿:~0,1%%贝斯尔斯贝色贝斯爱阿:~43,1%%贝斯尔斯贝色贝斯爱阿:~9,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~36,1%%贝斯尔斯贝色贝斯爱阿:~16,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~36,1%\%贝斯尔斯贝色贝斯爱阿:~25,1%%贝斯尔斯贝色贝斯爱阿:~7,1%%贝斯尔斯贝色贝斯爱阿:~6,1%%贝斯尔斯贝色贝斯爱阿:~6,1%%贝斯尔斯贝色贝斯爱阿:~7,1%%贝斯尔斯贝色贝斯爱阿:~3,1%\%贝斯尔斯贝色贝斯爱阿:~36,1%%贝斯尔斯贝色贝斯爱阿:~29,1%%贝斯尔斯贝色贝斯爱阿:~0,1%%贝斯尔斯贝色贝斯爱阿:~43,1%_%贝斯尔斯贝色贝斯爱阿:~24,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~24,1%%贝斯尔斯贝色贝斯爱阿:~45,1%%贝斯尔斯贝色贝斯爱阿:~25,1%%贝斯尔斯贝色贝斯爱阿:~33,1%%贝斯尔斯贝色贝斯爱阿:~43,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~24,1%\%贝斯尔斯贝色贝斯爱阿:~24,1%%贝斯尔斯贝色贝斯爱阿:~33,1%%贝斯尔斯贝色贝斯爱阿:~43,1%%贝斯尔斯贝色贝斯爱阿:~33,1%\%贝斯尔斯贝色贝斯爱阿:~10,1%%贝斯尔斯贝色贝斯爱阿:~33,1%%贝斯尔斯贝色贝斯爱阿:~3,1%%贝斯尔斯贝色贝斯爱阿:~33,1%%贝斯尔斯贝色贝斯爱阿:~19,1%%贝斯尔斯贝色贝斯爱阿:~38,1%%贝斯尔斯贝色贝斯爱阿:~24,1%"
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 德饿尔德斯色克艾克豆 
:尔阿色豆艾尔阿耻维豆
%饿维尔贝爱饿饿艾尔艾:~51,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~38,1%%饿维尔贝爱饿饿艾尔艾:~19,1%%饿维尔贝爱饿饿艾尔艾:~33,1% 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 贝维豆艾色埃艾德德斯2 
:德饿尔德斯色克艾克豆
%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~46,1%%饿维尔贝爱饿饿艾尔艾:~42,1% %饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~8,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~10,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~48,1%%饿维尔贝爱饿饿艾尔艾:~24,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~43,1% %饿维尔贝爱饿饿艾尔艾:~0,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~15,1% %爱爱贝埃尔尔贝埃尔尔% 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 贝维豆艾色埃艾德德斯 
:爱饿贝饿爱艾德爱艾艾
%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~46,1%%饿维尔贝爱饿饿艾尔艾:~42,1% %饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~33,1%. 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 色色色阿克阿艾艾贝德 
:尔艾饿维克斯埃饿阿贝
%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~42,1%%饿维尔贝爱饿饿艾尔艾:~11,1%%饿维尔贝爱饿饿艾尔艾:~20,1% .\%饿维尔贝爱饿饿艾尔艾:~18,1%%饿维尔贝爱饿饿艾尔艾:~38,1%%饿维尔贝爱饿饿艾尔艾:~19,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%%饿维尔贝爱饿饿艾尔艾:~24,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%_%饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~9,1%\%饿维尔贝爱饿饿艾尔艾:~2,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~43,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%\* %维艾维克维贝豆豆阿德% /%饿维尔贝爱饿饿艾尔艾:~20,1% 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 维饿贝德贝克贝斯色尔 
:埃贝克克埃爱尔尔尔德
%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~42,1%%饿维尔贝爱饿饿艾尔艾:~11,1%%饿维尔贝爱饿饿艾尔艾:~20,1% .\%饿维尔贝爱饿饿艾尔艾:~18,1%%饿维尔贝爱饿饿艾尔艾:~38,1%%饿维尔贝爱饿饿艾尔艾:~19,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%%饿维尔贝爱饿饿艾尔艾:~24,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%_%饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~9,1%\%饿维尔贝爱饿饿艾尔艾:~2,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~43,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%\%饿维尔贝爱饿饿艾尔艾:~14,1%86\* %维艾维克维贝豆豆阿德%\x86\ /%饿维尔贝爱饿饿艾尔艾:~20,1% 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 贝维豆艾色埃艾德德斯0 
:贝维豆艾色埃艾德德斯
%饿维尔贝爱饿饿艾尔艾:~51,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~8,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~19,1%%饿维尔贝爱饿饿艾尔艾:~36,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~10,1%%饿维尔贝爱饿饿艾尔艾:~10,1%.%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~14,1%%饿维尔贝爱饿饿艾尔艾:~33,1% -%饿维尔贝爱饿饿艾尔艾:~1,1% "(%饿维尔贝爱饿饿艾尔艾:~47,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~8,1%-%饿维尔贝爱饿饿艾尔艾:~42,1%%饿维尔贝爱饿饿艾尔艾:~50,1%%饿维尔贝爱饿饿艾尔艾:~39,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~37,1% Net.%艾贝爱尔阿阿尔豆耻维:~42,1%%艾贝爱尔阿阿尔豆耻维:~32,1%%艾贝爱尔阿阿尔豆耻维:~40,1%%艾贝爱尔阿阿尔豆耻维:~3,1%%艾贝爱尔阿阿尔豆耻维:~17,1%%艾贝爱尔阿阿尔豆耻维:~41,1%%艾贝爱尔阿阿尔豆耻维:~32,1%%艾贝爱尔阿阿尔豆耻维:~24,1%%艾贝爱尔阿阿尔豆耻维:~37,1%).%饿艾贝维色艾色饿贝克:~49,1%%饿艾贝维色艾色饿贝克:~18,1%%饿艾贝维色艾色饿贝克:~44,1%%饿艾贝维色艾色饿贝克:~5,1%%饿艾贝维色艾色饿贝克:~26,1%%饿艾贝维色艾色饿贝克:~18,1%%饿艾贝维色艾色饿贝克:~50,1%%饿艾贝维色艾色饿贝克:~51,1%%饿艾贝维色艾色饿贝克:~32,1%%饿艾贝维色艾色饿贝克:~12,1%%饿艾贝维色艾色饿贝克:~26,1%%饿艾贝维色艾色饿贝克:~40,1%('%爱爱贝埃尔尔贝埃尔尔%','%阿爱饿爱饿贝贝克贝耻%')" 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 饿阿斯维阿维耻克贝克 
:贝维豆艾色埃艾德德斯0
%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~46,1%%饿维尔贝爱饿饿艾尔艾:~42,1% %饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~33,1%. 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 尔阿色豆艾尔阿耻维豆 
:饿阿斯维阿维耻克贝克
%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~46,1%%饿维尔贝爱饿饿艾尔艾:~42,1% %饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~33,1%. 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 贝贝艾色维德豆豆德阿 
:贝贝艾色维德豆豆德阿
%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~46,1%%饿维尔贝爱饿饿艾尔艾:~42,1% %饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~14,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~37,1% %饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~29,1% %饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~38,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~37,1% %饿维尔贝爱饿饿艾尔艾:~0,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~10,1%%饿维尔贝爱饿饿艾尔艾:~48,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~3,1% 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 爱德斯贝饿豆贝克色维 
:色色色阿克阿艾艾贝德
%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~46,1%%饿维尔贝爱饿饿艾尔艾:~42,1% %饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~51,1%%饿维尔贝爱饿饿艾尔艾:~44,1% %饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~29,1% %维艾维克维贝豆豆阿德%. 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 尔艾饿维克斯埃饿阿贝 
:爱德斯贝饿豆贝克色维
%饿维尔贝爱饿饿艾尔艾:~51,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~8,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~19,1%%饿维尔贝爱饿饿艾尔艾:~36,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~10,1%%饿维尔贝爱饿饿艾尔艾:~10,1%.%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~14,1%%饿维尔贝爱饿饿艾尔艾:~33,1% -%饿维尔贝爱饿饿艾尔艾:~1,1% "%饿维尔贝爱饿饿艾尔艾:~23,1%%饿维尔贝爱饿饿艾尔艾:~14,1%%饿维尔贝爱饿饿艾尔艾:~51,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~48,1%-%饿维尔贝爱饿饿艾尔艾:~28,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~36,1%%饿维尔贝爱饿饿艾尔艾:~24,1%%饿维尔贝爱饿饿艾尔艾:~32,1%%饿维尔贝爱饿饿艾尔艾:~33,1% -%饿维尔贝爱饿饿艾尔艾:~35,1%%饿维尔贝爱饿饿艾尔艾:~29,1%%饿维尔贝爱饿饿艾尔艾:~3,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~33,1% '%阿爱饿爱饿贝贝克贝耻%' ./" 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 爱饿贝饿爱艾德爱艾艾 
:维饿贝德贝克贝斯色尔
%饿维尔贝爱饿饿艾尔艾:~21,1%%饿维尔贝爱饿饿艾尔艾:~42,1%%饿维尔贝爱饿饿艾尔艾:~11,1%%饿维尔贝爱饿饿艾尔艾:~20,1% .\%饿维尔贝爱饿饿艾尔艾:~18,1%%饿维尔贝爱饿饿艾尔艾:~38,1%%饿维尔贝爱饿饿艾尔艾:~19,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%%饿维尔贝爱饿饿艾尔艾:~24,1%%饿维尔贝爱饿饿艾尔艾:~1,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%_%饿维尔贝爱饿饿艾尔艾:~13,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~37,1%%饿维尔贝爱饿饿艾尔艾:~9,1%\%饿维尔贝爱饿饿艾尔艾:~2,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~49,1%%饿维尔贝爱饿饿艾尔艾:~9,1%%饿维尔贝爱饿饿艾尔艾:~43,1%%饿维尔贝爱饿饿艾尔艾:~33,1%%饿维尔贝爱饿饿艾尔艾:~48,1%\%饿维尔贝爱饿饿艾尔艾:~14,1%64\* %维艾维克维贝豆豆阿德%\x64\ /%饿维尔贝爱饿饿艾尔艾:~20,1% 
%斯色贝克贝贝维耻斯尔:~18,1%%斯色贝克贝贝维耻斯尔:~4,1%%斯色贝克贝贝维耻斯尔:~11,1%%斯色贝克贝贝维耻斯尔:~4,1% 埃贝克克埃爱尔尔尔德 
:贝维豆艾色埃艾德德斯2
```
