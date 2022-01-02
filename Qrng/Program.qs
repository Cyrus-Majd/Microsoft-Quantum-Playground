namespace Qrng {
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    // Generates a random bit via measuring a qubit in superposition.
    // Quantum state: (1/sqrt(2))(|0> + |1>)
    // RETURNS: Integer randomly generated bit.
    operation SampleQuantumRandomNumberGenerator() : Result {
        // Allocate a qubit        
        use q = Qubit();  
        // Put the qubit to superposition
        // It now has a 50% chance of being measured 0 or 1  
        H(q);      
        // Measure the qubit value            
        return M(q); 
    }

    // Generates a random number within a range from 0 to "max"
    // PARAM: Integer "max"
    // RETURNS: Integer "output" final RNG value.
    operation SampleRandomNumberInRange(max : Int) : Int {
        // Mutable variable to store RNG result.
        mutable output = 0; 
        // Continually make a random number until it satisfies the condition of being less than "max"
        repeat {
            // Mutable array to store generated bits into.
            mutable bits = new Result[0]; 
            // Generate a bit for as many bits as you need to get up to but not exceed "max"
            // example: if max is 8 then the BitSizeI(8) would give 3 because anything more than 111
            // is not valid anyway since it exceeds 8.
            for idxBit in 1..BitSizeI(max) {
                set bits += [SampleQuantumRandomNumberGenerator()]; 
            }
            // Convert array of binary values to a single integer.
            set output = ResultArrayAsInt(bits);
        } until (output <= max);
        return output;
    }

    @EntryPoint()
    // Driver method
    operation SampleRandomNumber() : Int {
        let max = 512;
        Message($"Sampling a random number between 0 and {max}: ");
        return SampleRandomNumberInRange(max);
    }
}