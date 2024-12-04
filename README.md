This repository demonstrates a common error in F# programming involving mutable variables.  The `bug.fs` file shows code that produces unexpected results due to the way F# handles mutable variables and expression evaluation. The `bugSolution.fs` file provides a corrected version of the code with comments explaining the changes and why they address the issue.  The solution ensures the calculation using the mutable variable happens after the variable is updated, leading to the expected outcome.