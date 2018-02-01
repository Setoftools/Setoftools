#define   Name "Set of tools"
; ������ ����������
#define   Version    "1.1.5.2"
; �����������
#define   Publisher  "�������� �.�."
; ��� ������������ ������
#define   ExeName    "Setoftools.exe"

;------------------------------------------------------------------------------
;   ��������� ���������
;------------------------------------------------------------------------------
[Setup]

; ���������� ������������� ����������, 
;��������������� ����� Tools -> Generate GUID
AppId={{567C9AD7-47CD-4F1A-9486-3E269D977026}}

; ������ ����������, ������������ ��� ���������
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}

; ���� ��������� ��-���������
DefaultDirName={pf}\{#Name}
; ��� ������ � ���� "����"
DefaultGroupName={#Name}

; �������, ���� ����� ������� ��������� setup � ��� ������������ �����
OutputDir=C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Setoftools
OutputBaseFileName=Setoftools

; ���� ������
SetupIconFile=C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\favicon.ico

; ��������� ������
Compression=lzma
SolidCompression=yes

;------------------------------------------------------------------------------
;   ������������� ����� ��� �������� ���������
;------------------------------------------------------------------------------
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\License_RUS.txt"

;------------------------------------------------------------------------------
;   ����������� - ��������� ������, ������� ���� ��������� ��� ���������
;------------------------------------------------------------------------------
[Tasks]
; �������� ������ �� ������� �����
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

;------------------------------------------------------------------------------
;   �����, ������� ���� �������� � ����� �����������
;------------------------------------------------------------------------------
[Files]

; ����������� ����
Source: "C:\Users\User\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\Setoftools.exe"; DestDir: "{app}"; Flags: ignoreversion