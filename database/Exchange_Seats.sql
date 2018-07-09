# Write your MySQL query statement below
# Write your MySQL query statement below
SELECT 
IF(id < (SELECT count(1) FROM seat), IF(id mod 2 = 0, id - 1, id + 1), IF(id mod 2 = 1, id, id - 1)) id,
student
FROM seat
ORDER BY id
