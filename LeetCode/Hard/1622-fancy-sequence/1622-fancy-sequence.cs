public class Fancy
{
    private const int _modulo = 1_000_000_007;

    private record struct Operation(long Mul = 1, long Inc = 0);
    private readonly Dictionary<int, Operation> _operations = [];

    private record struct Value(int OperationId, int Val);
    private readonly List<Value> _vals = [];

    private int _operationId = 0;
    private bool _canOptimize = false;

    public void Append(int val) 
    {
        _vals.Add(new(_operationId, val));
        _canOptimize = false;
    }
    public void AddAll(int inc) 
    {
        if (_canOptimize)
        {
            var op = _operations[_operationId - 1];
            _operations[_operationId - 1] = op with { Inc = (op.Inc + inc) % _modulo };
        }
        else
        {
            _operations.Add(_operationId, new(1, inc));
            _operationId++;
            _canOptimize = true;
        }
    }
    public void MultAll(int m) 
    {
        if (_canOptimize)
        {
            var op = _operations[_operationId - 1];
            _operations[_operationId - 1] = op with { Mul = op.Mul * m % _modulo, Inc = op.Inc * m % _modulo };
        }
        else
        {
            _operations.Add(_operationId, new(m, 0));
            _operationId++;
            _canOptimize = true;
        }
    }
    public int GetIndex(int idx) 
    {
        if (idx >= _vals.Count)
            return -1;

        var val = _vals[idx];
        long result = val.Val;
        for (var i = val.OperationId; i < _operationId; i++)
        {
            var op = _operations[i];
            result *= op.Mul;
            result %= _modulo;
            result += op.Inc;
            result %= _modulo;
        }
        return (int)result; 
    }
}