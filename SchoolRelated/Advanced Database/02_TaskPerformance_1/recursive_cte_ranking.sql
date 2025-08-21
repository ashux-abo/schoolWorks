USE DB_Sample
;WITH StudentRanks
as (
  SELECT *, 0 as Rank 
  FROM Students
  WHERE LeaderId IS NULL
  UNION ALL
  SELECT s.ID, s.Name, s.LeaderID, sr.Rank + 1 As Rank
  FROM Students s
  JOIN StudentRanks sr on s.LeaderID = sr.ID
  )
 SELECT * FROM StudentRanks
 ORDER by Rank, Name;