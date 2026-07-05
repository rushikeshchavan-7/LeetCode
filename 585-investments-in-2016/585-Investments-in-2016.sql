/* Write your PL/SQL query statement below */
select ROUND(SUM(tiv_2016), 2) Tiv_2016
  from (select t.Tiv_2016,
               count(*) Over(partition by t.Lat, t.Lon) Rn,
               count(*) Over(partition by t.Tiv_2015) Rm
          from Insurance t) t
 where t.Rn = 1
   and t.Rm > 1;