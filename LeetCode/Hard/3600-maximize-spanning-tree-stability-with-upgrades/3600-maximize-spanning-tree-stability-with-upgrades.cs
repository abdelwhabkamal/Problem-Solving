public class Solution {
    public class DSU
    {
        private int[] par, rank;
        private int size;

        public DSU(int n)
        {
            size = n;
            par = Enumerable.Range(0, n).ToArray();
            rank = new int[n];
        }

        public int FindPar(int x)
        {
            if(par[x] != x)
                par[x] = FindPar(par[x]);

            return par[x];
        }

        public void Union(int x, int y)
        {
            int parX = FindPar(x), parY = FindPar(y);
            if(parX != parY)
            {
                int rankX = rank[parX], rankY = rank[parY];
                if(rankX < rankY)
                {
                    par[parX] = parY;
                    rank[parY] += rank[parX];
                }
                else
                {
                    par[parY] = par[parX];
                    rank[parX] += rank[parY];
                }
            }
        }
    }
    private Dictionary<int, List<(int, int)>> adjs = new();
    private Dictionary<(int, int), int> mustConn = new();
    public int MaxStability(int n, int[][] edges, int k) {
        int res = int.MaxValue, mustVal = int.MaxValue;

        foreach(int[] cur in edges)
        {
            int n1 = cur[0], n2 = cur[1], w = cur[2], type = cur[3];
            var key = (n1, n2);
            if(type == 1)
            {
                mustConn.TryAdd(key, 0);
                mustConn[key]++;
                mustVal = Math.Min(mustVal, w);
            }

            adjs.TryAdd(w, new List<(int, int)>());
            adjs[w].Add(key);
        }

        List<int> keys = adjs.Keys.ToList();
        keys.Sort();

        int kLen = keys.Count;
        DSU dsuObj = new DSU(n);

        for(int i = kLen-1; i >= 0; i--) // build connection with must connected in the tree. return -1 if it's already connected;
        {
            int w = keys[i];
            foreach((int u, int v) in adjs[w])
            {
                Console.WriteLine($"{i}th, w {w}, ({u}, {v}).");
                if(mustConn.ContainsKey((u,v)))
                {
                    if(dsuObj.FindPar(u) == dsuObj.FindPar(v))
                        return -1;
                    else
                    {
                        dsuObj.Union(u, v);
                    }
                }
            }
        }

        PriorityQueue<int, int> pq = new();
        for(int i = kLen-1; i >= 0; i--)
        {
            int w = keys[i];
            foreach((int u, int v) in adjs[w])
            {
                if(!mustConn.ContainsKey((u, v)))
                {
                    if(dsuObj.FindPar(u) != dsuObj.FindPar(v))
                    {
                        pq.Enqueue(w, w);
                        dsuObj.Union(u, v);
                    }
                }
            }
        }

        while(pq.Count > 0)
        {
            int cur = pq.Dequeue();
            if(k > 0)
            {
                res = Math.Min(res, cur*2);
                k--;
            }
            else
                res = Math.Min(res, cur);
        }

        res = Math.Min(res, mustVal);
        int par0 = dsuObj.FindPar(0);
        for(int i = 1; i < n; i++)
        {
            if(dsuObj.FindPar(i) != par0)
                return -1;
        }

        return res;
    }
}