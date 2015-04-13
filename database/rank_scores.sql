SELECT s2.Score,s1.Rank From
(
SELECT Q1.Score, COUNT(*) as Rank
    FROM 
        (SELECT DISTINCT Score from Scores) as Q1,
        (SELECT DISTINCT Score from Scores) as Q2 
        Where Q1.Score<=Q2.Score
        Group By Q1.Score
) s1 ,Scores s2 
WHERE s1.Score = s2.Score Order BY s2.Score desc