use bloodbank;
SET IDENTITY_INSERT newDonor ON;
insert into newDonor (did,dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values(1,'shweta','sanjeev','ranjana','1998-09-19',7503587600,'Female','imsg19998@gmail.com','A+','Delhi','134sn');
select * from newDonor;