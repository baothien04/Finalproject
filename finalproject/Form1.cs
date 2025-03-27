﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            REATE TABLE[dbo].[rooms] (
    [roomid]   INT IDENTITY(1, 1)  PRIMARY KEY,
    [roomNo]   VARCHAR(250) NOT NULL,
    [roomType] VARCHAR(250) NOT NULL,
    [bed]      VARCHAR(250) NOT NULL,
    [price]    BIGINT NOT NULL,
    [booked] VARCHAR(50)  DEFAULT('NO') NULL
);


            CREATE TABLE[dbo].[customer] (
                [cid]         INT IDENTITY(1, 1) PRIMARY KEY,
            
                [cname]       VARCHAR(250) NOT NULL,
            
                [mobile]      BIGINT NOT NULL,
    [nationality] VARCHAR(250) NOT NULL,
    [gender]      VARCHAR(50)  NOT NULL,
    [dob]         VARCHAR(50)  NOT NULL,
    [idproof]     VARCHAR(250) NOT NULL,
    [address]     VARCHAR(350) NOT NULL,
    [checkin]     VARCHAR(250) NOT NULL,
    [checkout]    VARCHAR(250) ,
    [chekout] VARCHAR(250) DEFAULT('NO'),
    [roomid] INT NOT NULL,
    FOREIGN KEY([roomid]) REFERENCES[dbo].[rooms]([roomid])
);

            CREATE TABLE[dbo].[employee] (
                [eid]      INT IDENTITY(1, 1) NOT NULL,
            
                [ename]    VARCHAR(250) NOT NULL,
            
                [mobile]   BIGINT NOT NULL,
    [gender] VARCHAR(50)  NOT NULL,
    [emailid]  VARCHAR(120) NOT NULL,
    [username] VARCHAR(150) NOT NULL,
    [pass]     VARCHAR(150) NOT NULL,
    PRIMARY KEY CLUSTERED([eid] ASC)
);

        }
    }
}
