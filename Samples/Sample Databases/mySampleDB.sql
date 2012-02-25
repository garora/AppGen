/******************** This script is only for sample******************
*** to demostrate AppGen features https://github.com/garora/AppGen
*********************************************************************/
USE [MASTER]

IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'mySampleDB')
	DROP DATABASE [mySampleDB]
GO

CREATE DATABASE [mySampleDB] 
GO

USE [mySampleDB]

-- 
-- Table structure for table user_groups
-- 
CREATE TABLE [user_groups] (
	[ugid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY, 
	[name] VARCHAR(20) NOT NULL UNIQUE,
	[description] VARCHAR(Max) NOT NULL default '',
	[owner_id] INT NOT NULL  
) 
;

-- 
-- Table structure for table users
-- 
CREATE TABLE [users] (
  [uid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
  [users_name] VARCHAR(64) NOT NULL UNIQUE default '',
  [password] varchar(8000) NOT NULL default '', 
  [full_name] VARCHAR(50) NOT NULL,
  [parent_id] INT NOT NULL, 
  [email] VARCHAR(320) NOT NULL UNIQUE,
  [create_quiz] TINYINT NOT NULL default '0',
  [create_user] TINYINT NOT NULL default '0',
  [delete_user] TINYINT NOT NULL default '0',
  [superadmin] TINYINT NOT NULL default '0',
  [configurator] TINYINT NOT NULL default '0',
  [one_time_pw] TEXT NULL,
  );



-- 
-- Table structure for table user_in_groups
-- 
CREATE TABLE [user_in_groups] (
	[ugid] INT NOT NULL, 
	[uid] INT NOT NULL 
	
	CONSTRAINT [FK_user_in_groups_users] FOREIGN KEY([uid])
	REFERENCES [users] ([uid])
	) ;

--
-- Table : failed_login_attempts
--

CREATE TABLE [failed_login_attempts] (
  [id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
  [ip] varchar(37) NOT NULL,
  [last_attempt] varchar(20) NOT NULL,
  [number_attempts] int NOT NULL
);

-- 
-- Table : quiz_permissions
-- 
CREATE TABLE [quiz_permissions] (
    [qid] INT NOT NULL,         
    [uid] INT NOT NULL,         
    [permission] VARCHAR(20) NOT NULL,       
    [create_p] TINYINT NOT NULL default '0', 
    [read_p] TINYINT NOT NULL default '0', 
    [update_p] TINYINT NOT NULL default '0', 
    [delete_p] TINYINT NOT NULL default '0', 
    [import_p] TINYINT NOT NULL default '0', 
    [export_p] TINYINT NOT NULL default '0', 
    PRIMARY KEY ([qid], [uid],[permission])
);

-- 
-- Table : quiz_type
-- 
CREATE TABLE [quiz_type] (
    [qtid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    [description] VARCHAR(50) NOT NULL         
    );


-- 
-- Table : quiz template
-- 
CREATE TABLE [quiz_template] (
    [qztid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    [qzt_description] VARCHAR(max) NOT NULL,
    [qzt_Owner_Id] INT NOT NULL,
    [qzt_Creater_Id] INT NOT NULL,
    [isFixed] BIT NOT NULL DEFAULT 0,
    [max_questions] INT NOT NULL,
    [max_mandatory_questions] INT NOT NULL DEFAULT 0
    
    CONSTRAINT [FK_quiz_template_Users_qzt_Owner_Id] FOREIGN KEY([qzt_Owner_Id])
	REFERENCES [users] ([uid]) ,
		   
    CONSTRAINT [FK_quiz_template_Users_qzt_Creater_Id] FOREIGN KEY([qzt_Creater_Id])
	REFERENCES [users] ([uid])
	
    );



-- 
-- Table : quiz
-- 
CREATE TABLE [quiz] (
    [qzid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    [qzdescription] VARCHAR(max) NOT NULL,
    [qzOwner_Id] INT NOT NULL,
    [qzCreater_Id] INT NOT NULL,
    [qz_template_id] INT NOT NULL     
	
	
	CONSTRAINT [FK_quiz_Users_qzOwner_Id] FOREIGN KEY([qzOwner_Id])
	REFERENCES [users] ([uid]) ,
		   
    CONSTRAINT [FK_quiz_quiz_template_creator] FOREIGN KEY([qzCreater_Id])
	REFERENCES [users] ([uid]),
	
	CONSTRAINT [FK_quiz_quiz_template] FOREIGN KEY([qz_template_id])
	REFERENCES [quiz_template] ([qztid])
	   
    );

-- 
-- Table : question_type
-- 
CREATE TABLE [question_type] (
    [qstid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    [description] VARCHAR(50) NOT NULL         
    );

-- 
-- Table : questions
-- 
CREATE TABLE [questions] (
    [qsid] INT NOT NULL ,
    [qtitle] VARCHAR(50) NOT NULL,
    [qdescription] VARCHAR(Max) NOT NULL,
    [qstid] INT NOT NULL         
    PRIMARY KEY ([qsid], [qstid])
    
	CONSTRAINT [FK_question_type_questions] FOREIGN KEY([qstid])
	REFERENCES [question_type] ([qstid])    
    );

-- 
-- Table : answers
-- 
CREATE TABLE [answers] (
    [aid] INT NOT NULL IDENTITY (1,1),
    [qsid] INT NOT NULL ,
    [answer] INT NOT NULL,
    [adescription] VARCHAR(Max) NOT NULL DEFAULT ''
    PRIMARY KEY ([aid], [qsid])
    );

-- 
-- Table : correct_answers
-- 
CREATE TABLE [correct_answers] (
	[caid] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    [aid] INT NOT NULL
    
   );


-- 
-- Table : sessions
-- 
CREATE TABLE [sessions](
    [sess_key] VARCHAR( 64 ) NOT NULL DEFAULT '', --Users_Name
    expiry DATETIME NOT NULL ,
    created DATETIME NOT NULL ,
    modified DATETIME NOT NULL ,
    sessdata VARCHAR(MAX),
    CONSTRAINT pk_sessions_sess_key PRIMARY KEY ( [sess_key] ));
create index [idx_expiry] on [sessions] ([expiry]);

