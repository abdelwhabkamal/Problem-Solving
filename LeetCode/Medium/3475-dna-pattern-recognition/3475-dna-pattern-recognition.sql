/* Write your T-SQL query statement below */
select sample_id , dna_sequence , species ,
case when dna_sequence like 'ATG%' then 1 else 0 end as has_start,
CASE WHEN dna_sequence LIKE '%TAA' OR dna_sequence LIKE '%TAG' OR dna_sequence LIKE '%TGA' 
    THEN 1 
    ELSE 0 
END AS has_stop,
case when dna_sequence like '%ATAT%' then 1 else 0 end as has_atat,
case when dna_sequence like '%GGG%' then 1 else 0 end as has_ggg
from samples