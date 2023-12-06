using System.Xml.Linq;

namespace Collection
{
    public class IntList
    {
        int[] _array;

        public void Add(int number)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = number;
        }

        public void Add(params int[] numbers)
        {
            int oldLength = _array.Length;
            Array.Resize(ref _array, _array.Length + numbers.Length);
            for (int i = oldLength; i < _array.Length; i++)
            {
                _array[i] = numbers[i - oldLength];
            }
        }

        //public int Get(int index)
        //{
        //    if (index > _array.Length)
        //    {
        //        Console.WriteLine("Index out of range");
        //        return -1;
        //    }
        //    return _array[index];
        //}

        //public int[] GetAll()
        //{
        //    return _array;
        //}

        //public void Print()
        //{
        //    foreach (int i in _array)
        //    {
        //        //Console.Write(i + ", ");
        //        Console.Write(i);
        //        if (i != _array[_array.Length - 1])
        //        {
        //            Console.Write(", ");
        //        }
        //    }
        //}

        //public void Sort()
        //{
        //    int n = _array.Length;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (_array[j] > _array[j + 1])
        //            { 
        //                Swap(i, j);
        //            }
        //        }
        //    }
        //}

        //public void QuickSort()
        //{
        //    int[] temp = new int[_array.Length];
        //    int top = -1;

        //    temp[++top] = 0;
        //    temp[++top] = _array.Length - 1;

        //    while (top >= 0)
        //    {
        //        int high = temp[top--];
        //        int low = temp[top--];

        //        int pivotIndex = Partition(low, high);

        //        if (pivotIndex - 1 > low)
        //        {
        //            temp[++top] = low;
        //            temp[++top] = pivotIndex - 1;
        //        }

        //        if (pivotIndex + 1 < high)
        //        {
        //            temp[++top] = pivotIndex + 1;
        //            temp[++top] = high;
        //        }
        //    }
        //}

        //private int Partition(int low, int high)
        //{
        //    int pivot = _array[high];
        //    int i = (low - 1);

        //    for (int j = low; j < high; j++)
        //    {
        //        if (_array[j] < pivot)
        //        {
        //            i++;
        //            Swap(i, j);
        //        }
        //    }

        //    Swap(i + 1, high);
        //    return i + 1;
        //}

        //private void Swap(int i, int j)
        //{
        //    int temp = _array[i];
        //    _array[i] = _array[j];
        //    _array[j] = temp;
        //}

        //public int BinarySearch(int target)
        //{
        //    int left = 0;
        //    int right = _array.Length - 1;

        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;

        //        if (_array[mid] == target)
        //        {
        //            return mid;
        //        }
        //        else if (_array[mid] < target)
        //        {
        //            left = mid + 1;
        //        }
        //        else
        //        {
        //            right = mid - 1;
        //        }
        //    }

        //    return -1;
        //}

        public IntList (params int[] numbers)
        {
            _array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                _array[i] = numbers[i];
            }
        }
    }
}