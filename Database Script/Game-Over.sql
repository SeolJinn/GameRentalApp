if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_MANAGE_ADMIN')
alter table GAME
   drop constraint FK_GAME_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT_CLIENT')
alter table RENT
   drop constraint FK_RENT_RENT_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT2_GAME')
alter table RENT
   drop constraint FK_RENT_RENT2_GAME
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME')
            and   type = 'U')
   drop table GAME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENT')
            and   type = 'U')
   drop table RENT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   A_USERNAME           varchar(80)          not null,
   A_PASSWORD           varchar(50)          not null,
   constraint PK_ADMIN primary key (A_USERNAME)
)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   C_USERNAME           varchar(80)          not null,
   C_PASSWORD           varchar(50)          not null,
   C_FIRSTNAME          varchar(50)          not null,
   C_LASTNAME           varchar(50)          not null,
   C_PHONENUM           varchar(11)          not null,
   constraint PK_CLIENT primary key (C_USERNAME)
)
go

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
create table GAME (
   G_NAME               varchar(100)         not null,
   A_USERNAME           varchar(80)          null,
   V_NAME               varchar(50)          not null,
   G_CATEGORY           varchar(50)          not null,
   G_AMOUNT             int                  not null,
   G_PRICE              float                not null,
   G_DATE               datetime             not null,
   G_PHOTO              image                not null,
   constraint PK_GAME primary key (G_NAME)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/




create nonclustered index MANAGE_FK on GAME (A_USERNAME ASC)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   R_ID                 int                  not null identity(1,1),
   C_USERNAME           varchar(80)          not null,
   G_NAME               varchar(100)         not null,
   RENT_DATE            datetime             not null,
   RETURN_DATE          datetime             null,
   constraint PK_RENT primary key (R_ID)
)
go

/*==============================================================*/
/* Index: RENT_FK                                               */
/*==============================================================*/




create nonclustered index RENT_FK on RENT (C_USERNAME ASC)
go

/*==============================================================*/
/* Index: RENT2_FK                                              */
/*==============================================================*/




create nonclustered index RENT2_FK on RENT (G_NAME ASC)
go

alter table GAME
   add constraint FK_GAME_MANAGE_ADMIN foreign key (A_USERNAME)
      references ADMIN (A_USERNAME)
go

alter table RENT
   add constraint FK_RENT_RENT_CLIENT foreign key (C_USERNAME)
      references CLIENT (C_USERNAME)
go

alter table RENT
   add constraint FK_RENT_RENT2_GAME foreign key (G_NAME)
      references GAME (G_NAME)
go

INSERT [dbo].[ADMIN] ([A_USERNAME], [A_PASSWORD]) VALUES (N'alex', N'alex1234')
INSERT [dbo].[ADMIN] ([A_USERNAME], [A_PASSWORD]) VALUES (N'alice', N'alice1234')
GO
