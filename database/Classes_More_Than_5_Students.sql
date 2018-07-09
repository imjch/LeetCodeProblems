# Write your MySQL query statement below
SELECT t.class FROM (SELECT count(1) as cnt, student, class FROM courses GROUP BY student, class) t GROUP BY t.class HAVING count(*) >= 5 
