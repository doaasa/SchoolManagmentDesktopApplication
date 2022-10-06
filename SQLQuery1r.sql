 SELECT * from Course where Course.Course_ID  in (SELECT Score.Course_ID from Score where Score.Student_ID =4)
