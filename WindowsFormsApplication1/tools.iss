#define   Name "Set of tools"
; Версия приложения
#define   Version    "1.1.5.2"
; Разработчик
#define   Publisher  "Федорова А.В."
; Имя исполняемого модуля
#define   ExeName    "Setoftools.exe"

;------------------------------------------------------------------------------
;   Параметры установки
;------------------------------------------------------------------------------
[Setup]

; Уникальный идентификатор приложения, 
;сгенерированный через Tools -> Generate GUID
AppId={{567C9AD7-47CD-4F1A-9486-3E269D977026}}

; Прочая информация, отображаемая при установке
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}

; Путь установки по-умолчанию
DefaultDirName={pf}\{#Name}
; Имя группы в меню "Пуск"
DefaultGroupName={#Name}

; Каталог, куда будет записан собранный setup и имя исполняемого файла
OutputDir=C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Setoftools
OutputBaseFileName=Setoftools

; Файл иконки
SetupIconFile=C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\favicon.ico

; Параметры сжатия
Compression=lzma
SolidCompression=yes

;------------------------------------------------------------------------------
;   Устанавливаем языки для процесса установки
;------------------------------------------------------------------------------
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\License_RUS.txt"

;------------------------------------------------------------------------------
;   Опционально - некоторые задачи, которые надо выполнить при установке
;------------------------------------------------------------------------------
[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

;------------------------------------------------------------------------------
;   Файлы, которые надо включить в пакет установщика
;------------------------------------------------------------------------------
[Files]

; Исполняемый файл
Source: "C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\Setoftools.exe"; DestDir: "{app}"; Flags: ignoreversion