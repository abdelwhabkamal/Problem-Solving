public class Solution {
    public int LongestBalanced(string s) {
        int maxLength = 1;
        // 1 distinct
        int count;
        for(int i=1;i<s.Length;i++){
            count =1;
            while(i<s.Length && s[i]==s[i-1]){
                count++;
                i++;
            }
            maxLength = Math.Max(maxLength,count);
        }
        // 2 distinct
        Dictionary<int,int> abd = new Dictionary<int,int>(){{0,-1}};
        Dictionary<int,int> bcd = new Dictionary<int,int>(){{0,-1}};
        Dictionary<int,int> cad = new Dictionary<int,int>(){{0,-1}};
        int ab=0,bc=0,ca=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='a'){
                ab += 1;
                maxLength = UpdateDictAndFindMax(ab,abd,i,maxLength);                
                ca += -1; 
                maxLength = UpdateDictAndFindMax(ca,cad,i,maxLength);                 
                bc = 0;
                ClearDict(bcd,i);
            }else if(s[i]=='b'){
                bc += 1;
                maxLength = UpdateDictAndFindMax(bc,bcd,i,maxLength);  
                ab += -1;
                maxLength = UpdateDictAndFindMax(ab,abd,i,maxLength);  
                ca = 0;
                ClearDict(cad,i);
            }else{
                ca += 1;
                maxLength = UpdateDictAndFindMax(ca,cad,i,maxLength);  
                bc += -1;
                maxLength = UpdateDictAndFindMax(bc,bcd,i,maxLength);  
                ab = 0;
                ClearDict(abd,i);
            }
        }
        // 3 distinct
        int cntA=0,cntB=0,cntC=0;
        Dictionary<(int,int),int> d = new Dictionary<(int,int),int>();
        d[(0,0)] = -1;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='a') cntA++;
            if(s[i]=='b') cntB++;
            if(s[i]=='c') cntC++;
            var val = (cntA-cntB,cntA-cntC);
            if(d.ContainsKey(val)){
                maxLength = Math.Max(maxLength,i-d[val]);
            }else{
                d[val] = i;
            }
        }
        return maxLength;
    }

    private int UpdateDictAndFindMax(int val,Dictionary<int,int> d,int index,int max){
        if(d.ContainsKey(val)) max = Math.Max(max,index-d[val]);
        else d[val]=index;
        return max;
    }

    private void ClearDict(Dictionary<int,int> d,int i){
        d.Clear();
        d[0]=i;
    }
}