select * from Course where Course_ID  in (select Score.Course_ID from Score where Score.Student_ID=12 )

 