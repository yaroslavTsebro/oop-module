# Modul-1 (Coding)

**��������**: ���������� �������� ��������� ����.   
**�����������**: ����� ��������� �������� ��� ������������� ���������� ���������� � ������.

��������� ����� �� ��������� ��������� ������ �����:

![ĳ������ �����](images/ClassDiagram.jpg)


## �������� �������
- ���� ������� �������� �������� ��������� �����: **"�������� ������ �������� N"** *(������ N ��������� ����� ���������� ��������, ������� ����� ������ �� ������)*
- ��� ����� Program.cs ������� ����� � �����, ���������� //TODO 3 � //TODO 4. ����� ��� � ����� ���� �� �������!
- ������ �������� �� ������������ � �����������! *(������ coding ���������� � 0 ����)* 
- �������� ����� ������ ����� 20 �����, ����� ���� ���������� � 0.5 ����, ����� �� coding ����� �������� 10 ����!

## �������� (TODO 1)

� ��������� ������ ���������� ���� ���� ����. ���������� ���������� ����� � �������� �����.

## �������� (TODO 2)

��������� � ����� ��������� ������ **Tank**, ��������� ����� �� ��������� ������ �����.

**�������� ���� ��������� ������������ ����� Tank:**
- **CriticalPercentage** - ������� ���������� ���������� (����� �� ��� ������� ��������� � ����� �� ����� ���������), �� ������������� ������� 90 (�����, ���� ������ ���������� ������� 1000 �, �� ���� �������� ������������� ������ 1000*90% = 900 �)
- **TankCount** - �������� ��������� ����������

**�������� � ����������� �� �������� ����� Tank:**
- **id** - ����� ���������� (�� ���� ���� ������ ������)
- **�apasity** - ������ ���������� (�� ���� ���� ��'����� ������ ��� ���������� 0)
- **current amount** - ������� ������� ���� � ��������� (�� ���� ���� ��'����� ������, � ����� �� ���� ���� ������ �� �������, ��� ������������� �� ����� ���������� ������� ������������ ����������)
- **juice** - ��� ���� � ��������� (����� ���� ����� �� ���������� �������, ���� ��������� ������, �� ��� ���� UNKNOWN)

**�������� ���� �������������� ������������ ����� Tank:**
- **IsFree** - ������� �� ������ ���������
- **IsFull** - ������� �� ������ ��������� (*���'����� ��� ��������� �������!*)
- **FreeAmount** - ������� ����, ��� ����� ������ �� ���������� �������

**�������� ���� ������������ ����� Tank:**
- **� ����� �����������** - ���. �������
- **� ������� �����������** - ���. �������, ����� �� �� ��������� ����������� � ����� �����������

**�������� ���� ������ ����� Tank:**
- **AddJuice(...)** - � ��������� ����� ������ ��, ���� � �������� ����� ���� (*���'����� ��� ��������� �������!*), � ����� ����� ������ ����� ������� �� (�������� �� ���������, ������������ �� ������������� � �.�.)
- **MakeFree()** - ����� ���������
- **GetInfo()** - ������� ����� � ������: **Id: tank_05, Capasity: 1000, Current amount: 150, Juice type: TOMATO**

**�������� ���� ���������� ������ ����� Tank:**
- **ChangeCriticalPercentage(...)** - ����� �������� ������� ���������� ���������� ����������, �� ���� ���� ��'�����, � ����� ������ �� 100.

## �������� (TODO 3)

� ���� Program ������ ������ AllowedPour(...) � PourJuice(...).

**�������� ���� ������ ����� Program:**
- **AllowedPour(Tank t1, Tank t2)** - ������� �� ����� ���������� ����������� � ���������� t2 � ��������� t1.
- **PourJuice(Tank t1, Tank t2)** - ������� ����� AllowedPour(...) � ���� ����� �������� � ���������� t2 � ��������� t1, �� �������� � �������� �� ����� ����������� "Process is OK!", ������ �������� ����������� "Process isn't OK!"


## �������� (TODO 4)

� ����� Main(), ��������� � ����� #17, � �������� ��������, ����� � ������� ������!
