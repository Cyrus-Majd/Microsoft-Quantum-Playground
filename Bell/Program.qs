
//
// NOTE: TO RUN THIS PROGRAM YOU MUST PASS IN PARAMETERS --COUNT X AND --INITIAL Y WHERE X IS A NUMBER AND Y IS EITHER "ZERO" OR "ONE"
//

namespace Bell {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

    // This operation sets the value of the qubit to whatever the value of "desired" is.
    // PARAMS: Desired measured quantum state "desired" and input qubit "target"
    operation SetQubitState(desired : Result, target : Qubit) : Unit {
        if desired != M(target) {
            X(target);
        }
    }

    @EntryPoint()
    // Entry point of program.
    // PARAMS: Number of times to run a measurement "count" and desired state to initialize the qubit "initial".
    // RETURNS: Entangled pair of qubits in a Bell State. Has a 50%-50% chance of returning the state |00> or |11>
    operation TestBellState(count : Int, initial : Result) : (Int, Int, Int, Int) {
        mutable numOnesQ1 = 0;
        mutable numOnesQ2 = 0;

        // allocate the qubits
        use (q1, q2) = (Qubit(), Qubit());   
        for test in 1..count {
            SetQubitState(initial, q1);
            SetQubitState(Zero, q2);
            
            // Put qubit #1 into superposition.
            H(q1);

            // Entangle qubit #1 and qubit #2 via CNOT.
            CNOT(q1, q2);

            // measure each qubit
            let resultQ1 = M(q1);            
            let resultQ2 = M(q2);           

            // Count the number of 'Ones' we saw:
            if resultQ1 == One {
                set numOnesQ1 += 1;
            }
            if resultQ2 == One {
                set numOnesQ2 += 1;
            }
        }

        // reset the qubits
        SetQubitState(Zero, q1);             
        SetQubitState(Zero, q2);
        

        // Return times we saw |0>, times we saw |1>
        Message("q1: Zero, One  q2: Zero, One");
        return (count - numOnesQ1, numOnesQ1, count - numOnesQ2, numOnesQ2 );
    }
}