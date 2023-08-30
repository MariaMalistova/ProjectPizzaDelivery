/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2000                    */
/* Created on:     18.05.2019 15:12:51                          */
/*==============================================================*/


/*==============================================================*/
/* Table: Доставка                                              */
/*==============================================================*/
create table Доставка (
   Код_Доставки         int                  identity,
   Тип                  varchar(50)          not null,
   Стоимость            money                not null
)
go

alter table Доставка
   add constraint PK_ДОСТАВКА primary key nonclustered (Код_Доставки)
go

alter table Доставка
   add constraint AK_AK_ДОСТАВКА_ТИП_ДОСТАВКА unique (Тип)
go

/*==============================================================*/
/* Table: Заказ                                                 */
/*==============================================================*/
create table Заказ (
   Номер                int                  identity,
   Сумма                money                not null,
   Покупатель           int                  not null,
   Курьер               int                  null,
   Доставка             int                  not null,
   Пункт                int                  not null,
   Статус               int                  not null,
   Скидка               int                  null,
   Дата_Заказа          datetime             not null
)
go

alter table Заказ
   add constraint PK_ЗАКАЗ primary key nonclustered (Номер)
go

/*==============================================================*/
/* Table: Курьер                                                */
/*==============================================================*/
create table Курьер (
   Код_Курьера          int                  identity,
   Пункт                int                  not null,
   Фамилия              varchar(50)          not null,
   Имя                  varchar(50)          not null,
   Отчество             varchar(50)          not null
)
go

alter table Курьер
   add constraint PK_КУРЬЕР primary key nonclustered (Код_Курьера)
go

/*==============================================================*/
/* Table: Пицца                                                 */
/*==============================================================*/
create table Пицца (
   Код_Пиццы            int                  identity,
   Название             varchar(50)          not null,
   Масса                float                not null,
   Цена                 money                not null,
   Доступна_к_Заказу    bit                  not null
)
go

alter table Пицца
   add constraint PK_ПИЦЦА primary key nonclustered (Код_Пиццы)
go

alter table Пицца
   add constraint AK_AK_ПИЦЦА_НАЗВАНИЕ_ПИЦЦА unique (Название)
go

/*==============================================================*/
/* Table: Пицца_в_Заказе                                        */
/*==============================================================*/
create table Пицца_в_Заказе (
   Зак_Номер            int                  not null,
   Пиц_Код_Пиццы        int                  not null,
   Количество           int                  not null default 1
)
go

alter table Пицца_в_Заказе
   add constraint CKC_КОЛИЧЕСТВО_ПИЦЦА_В_ check (Количество >= 1)
go

alter table Пицца_в_Заказе
   add constraint PK_ПИЦЦА_В_ЗАКАЗЕ primary key nonclustered (Зак_Номер, Пиц_Код_Пиццы)
go

/*==============================================================*/
/* Table: Покупатель                                            */
/*==============================================================*/
create table Покупатель (
   Код_Покупателя       int                  identity,
   Фамилия              varchar(50)          not null,
   Имя                  varchar(50)          not null,
   Отчество             varchar(50)          not null,
   Телефон              varchar(50)          null,
   Адрес                varchar(100)         not null
)
go

alter table Покупатель
   add constraint PK_ПОКУПАТЕЛЬ primary key nonclustered (Код_Покупателя)
go

/*==============================================================*/
/* Table: Пункт                                                 */
/*==============================================================*/
create table Пункт (
   Код_Пункта           int                  identity,
   Адрес                varchar(50)          not null
)
go

alter table Пункт
   add constraint PK_ПУНКТ primary key nonclustered (Код_Пункта)
go

/*==============================================================*/
/* Table: Скидка                                                */
/*==============================================================*/
create table Скидка (
   Код_Скидки           int                  identity,
   Вид                  varchar(50)          not null,
   Процент              float                not null
)
go

alter table Скидка
   add constraint CKC_ПРОЦЕНТ_СКИДКА check (Процент between 0 and 100)
go

alter table Скидка
   add constraint PK_СКИДКА primary key nonclustered (Код_Скидки)
go

/*==============================================================*/
/* Table: Статус_Заказа                                         */
/*==============================================================*/
create table Статус_Заказа (
   Код_Статуса          int                  identity,
   Вид                  varchar(50)          not null
)
go

alter table Статус_Заказа
   add constraint PK_СТАТУС_ЗАКАЗА primary key nonclustered (Код_Статуса)
go

alter table Заказ
   add constraint FK_ЗАКАЗ_ВЫПОЛНЯЕТ_КУРЬЕР foreign key (Курьер)
      references Курьер (Код_Курьера)
         on update cascade
go

alter table Заказ
   add constraint FK_ЗАКАЗ_ВЫПОЛНЯЕТ_ПУНКТ foreign key (Пункт)
      references Пункт (Код_Пункта)
         on update cascade
go

alter table Заказ
   add constraint FK_ЗАКАЗ_ДЕЛАЕТ_ПОКУПАТЕ foreign key (Покупатель)
      references Покупатель (Код_Покупателя)
         on update cascade
go

alter table Заказ
   add constraint FK_ЗАКАЗ_ИМЕЕТ_СКИДКА foreign key (Скидка)
      references Скидка (Код_Скидки)
         on update cascade
go

alter table Заказ
   add constraint FK_ЗАКАЗ_ПРИСВАИВА_СТАТУС_З foreign key (Статус)
      references Статус_Заказа (Код_Статуса)
         on update cascade
go

alter table Заказ
   add constraint FK_ЗАКАЗ_СОВЕРШАЕТ_ДОСТАВКА foreign key (Доставка)
      references Доставка (Код_Доставки)
         on update cascade
go

alter table Курьер
   add constraint FK_КУРЬЕР_ОТНОСИТСЯ_ПУНКТ foreign key (Пункт)
      references Пункт (Код_Пункта)
      --   on update cascade
go

alter table Пицца_в_Заказе
   add constraint FK_ПИЦЦА_В__ВХОДИТ_ЗАКАЗ foreign key (Зак_Номер)
      references Заказ (Номер)
         on update cascade
go

alter table Пицца_в_Заказе
   add constraint FK_ПИЦЦА_В__ВХОДИТ2_ПИЦЦА foreign key (Пиц_Код_Пиццы)
      references Пицца (Код_Пиццы)
         on update cascade
go