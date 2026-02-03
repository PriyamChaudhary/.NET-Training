use LPU_DB

--Question 9 DETECTING DUPLICATE--
select Email, count(*) from Users group by Email having count(*)>1;

--Question 10 DISPLAY PRODUCTS--
select * from Products
where ProductId not in
(select ProductId from Sales);


--Question 11 DELETE STUDENT--
delete from Students
where Student_Id not in 
( select Student_Id from Marks);


