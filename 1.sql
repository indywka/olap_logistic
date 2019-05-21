USE [C:\USERS\USER\DESKTOP\ДИПЛОМ-ПРОГРАММА\OLAP-MASTER\OLAP\APP_DATA\MANAGMENT.MDF]

CREATE TABLE Водители (
	ВодительID           int IDENTITY(1,1),
	ФИО                  varchar(50) NOT NULL,
    МобТелефон           varchar(12) NOT NULL
       
       
)
go


ALTER TABLE Водители
       ADD PRIMARY KEY NONCLUSTERED (ВодительID)
go


CREATE TABLE ЗаказаноТоваров (
       ЗаказID              int NOT NULL,
       КодТовара            int NOT NULL,
       РасценкаТоннЗаКм     money NOT NULL,
       Количество           int NOT NULL,
       Масса                int NOT NULL
)
go


ALTER TABLE ЗаказаноТоваров
       ADD PRIMARY KEY NONCLUSTERED (КодТовара, ЗаказID)
go


CREATE TABLE Заказы (
       ЗаказID              int IDENTITY(1,1),
       СрокПоставки         date NOT NULL,
       ДатаЗаказа           date NOT NULL,
       КлиентID             int NOT NULL,
       МестоНазначения      varchar(50) NOT NULL,
       СостояниеID          int NOT NULL,
       ДатаДоставки         date NULL,
       ТрСредствоID         int NOT NULL,
       ВодительID           int NOT NULL
)
go


ALTER TABLE Заказы
       ADD PRIMARY KEY NONCLUSTERED (ЗаказID)
go


CREATE TABLE Клиенты (
       КлиентID             int IDENTITY(1,1),
       ФИО                  varchar(50) NOT NULL,
       Адрес                varchar(50) NOT NULL,
       Телефон              varchar(20) NOT NULL
)
go


ALTER TABLE Клиенты
       ADD PRIMARY KEY NONCLUSTERED (КлиентID)
go


CREATE TABLE СкладТоваров (
       КодТовара            int IDENTITY(1,1),
       Остаток              INTEGER NOT NULL,
       Цена                 MONEY NOT NULL,
       Наименование         varchar(50) NOT NULL
)
go


ALTER TABLE СкладТоваров
       ADD PRIMARY KEY NONCLUSTERED (КодТовара)
go


CREATE TABLE СостояниеЗаказа (
	СостояниеID          int NOT NULL,
    Состояние            varchar(50) NOT NULL
       
)
go


ALTER TABLE СостояниеЗаказа
       ADD PRIMARY KEY NONCLUSTERED (СостояниеID)
go


CREATE TABLE ТранспортноеСредство (
       ТрСредствоID         int IDENTITY(1,1),
       Марка                varchar(20) NOT NULL,
       Грузоподъемность     float NOT NULL
)
go


ALTER TABLE ТранспортноеСредство
       ADD PRIMARY KEY NONCLUSTERED (ТрСредствоID)
go


ALTER TABLE ЗаказаноТоваров
       ADD FOREIGN KEY (КодТовара)
                             REFERENCES СкладТоваров
go


ALTER TABLE ЗаказаноТоваров
       ADD FOREIGN KEY (ЗаказID)
                             REFERENCES Заказы
go


ALTER TABLE Заказы
       ADD FOREIGN KEY (ВодительID)
                             REFERENCES Водители
go


ALTER TABLE Заказы
       ADD FOREIGN KEY (ТрСредствоID)
                             REFERENCES ТранспортноеСредство
go


ALTER TABLE Заказы
       ADD FOREIGN KEY (СостояниеID)
                             REFERENCES СостояниеЗаказа
go


ALTER TABLE Заказы
       ADD FOREIGN KEY (КлиентID)
                             REFERENCES Клиенты
go



