/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2000                    */
/* Created on:     18.05.2019 15:12:51                          */
/*==============================================================*/


/*==============================================================*/
/* Table: ��������                                              */
/*==============================================================*/
create table �������� (
   ���_��������         int                  identity,
   ���                  varchar(50)          not null,
   ���������            money                not null
)
go

alter table ��������
   add constraint PK_�������� primary key nonclustered (���_��������)
go

alter table ��������
   add constraint AK_AK_��������_���_�������� unique (���)
go

/*==============================================================*/
/* Table: �����                                                 */
/*==============================================================*/
create table ����� (
   �����                int                  identity,
   �����                money                not null,
   ����������           int                  not null,
   ������               int                  null,
   ��������             int                  not null,
   �����                int                  not null,
   ������               int                  not null,
   ������               int                  null,
   ����_������          datetime             not null
)
go

alter table �����
   add constraint PK_����� primary key nonclustered (�����)
go

/*==============================================================*/
/* Table: ������                                                */
/*==============================================================*/
create table ������ (
   ���_�������          int                  identity,
   �����                int                  not null,
   �������              varchar(50)          not null,
   ���                  varchar(50)          not null,
   ��������             varchar(50)          not null
)
go

alter table ������
   add constraint PK_������ primary key nonclustered (���_�������)
go

/*==============================================================*/
/* Table: �����                                                 */
/*==============================================================*/
create table ����� (
   ���_�����            int                  identity,
   ��������             varchar(50)          not null,
   �����                float                not null,
   ����                 money                not null,
   ��������_�_������    bit                  not null
)
go

alter table �����
   add constraint PK_����� primary key nonclustered (���_�����)
go

alter table �����
   add constraint AK_AK_�����_��������_����� unique (��������)
go

/*==============================================================*/
/* Table: �����_�_������                                        */
/*==============================================================*/
create table �����_�_������ (
   ���_�����            int                  not null,
   ���_���_�����        int                  not null,
   ����������           int                  not null default 1
)
go

alter table �����_�_������
   add constraint CKC_����������_�����_�_ check (���������� >= 1)
go

alter table �����_�_������
   add constraint PK_�����_�_������ primary key nonclustered (���_�����, ���_���_�����)
go

/*==============================================================*/
/* Table: ����������                                            */
/*==============================================================*/
create table ���������� (
   ���_����������       int                  identity,
   �������              varchar(50)          not null,
   ���                  varchar(50)          not null,
   ��������             varchar(50)          not null,
   �������              varchar(50)          null,
   �����                varchar(100)         not null
)
go

alter table ����������
   add constraint PK_���������� primary key nonclustered (���_����������)
go

/*==============================================================*/
/* Table: �����                                                 */
/*==============================================================*/
create table ����� (
   ���_������           int                  identity,
   �����                varchar(50)          not null
)
go

alter table �����
   add constraint PK_����� primary key nonclustered (���_������)
go

/*==============================================================*/
/* Table: ������                                                */
/*==============================================================*/
create table ������ (
   ���_������           int                  identity,
   ���                  varchar(50)          not null,
   �������              float                not null
)
go

alter table ������
   add constraint CKC_�������_������ check (������� between 0 and 100)
go

alter table ������
   add constraint PK_������ primary key nonclustered (���_������)
go

/*==============================================================*/
/* Table: ������_������                                         */
/*==============================================================*/
create table ������_������ (
   ���_�������          int                  identity,
   ���                  varchar(50)          not null
)
go

alter table ������_������
   add constraint PK_������_������ primary key nonclustered (���_�������)
go

alter table �����
   add constraint FK_�����_���������_������ foreign key (������)
      references ������ (���_�������)
         on update cascade
go

alter table �����
   add constraint FK_�����_���������_����� foreign key (�����)
      references ����� (���_������)
         on update cascade
go

alter table �����
   add constraint FK_�����_������_�������� foreign key (����������)
      references ���������� (���_����������)
         on update cascade
go

alter table �����
   add constraint FK_�����_�����_������ foreign key (������)
      references ������ (���_������)
         on update cascade
go

alter table �����
   add constraint FK_�����_���������_������_� foreign key (������)
      references ������_������ (���_�������)
         on update cascade
go

alter table �����
   add constraint FK_�����_���������_�������� foreign key (��������)
      references �������� (���_��������)
         on update cascade
go

alter table ������
   add constraint FK_������_���������_����� foreign key (�����)
      references ����� (���_������)
      --   on update cascade
go

alter table �����_�_������
   add constraint FK_�����_�__������_����� foreign key (���_�����)
      references ����� (�����)
         on update cascade
go

alter table �����_�_������
   add constraint FK_�����_�__������2_����� foreign key (���_���_�����)
      references ����� (���_�����)
         on update cascade
go