
# Neural Network Training for a 4-Input AND Gate

This project implements a 4-input AND gate using a neural network. Below is a summary of the training process, validation method, and the results.

## Problem Statement

The goal is to train a neural network to learn the behavior of a 4-input AND gate. The training set contains 16 combinations of inputs and expected outputs, corresponding to all possible binary input combinations.

## Validation Process

To ensure accurate results, the following validation pseudocode is used:

```python
def validateData():
    for x in training_set:
        nnet.setInputs(0, x[0])
        nnet.setInputs(1, x[1])
        nnet.setInputs(2, x[2])
        nnet.setInputs(3, x[3])
        nnet.run()

        if nnet.output() != x.expected_output:
            return False

    return True
```

### Assumption
The neural network output is considered correct if the output is ≤ 0.5 (rounded up).

---

## Findings

### Minimum Number of Hidden Neurons
Through experimentation, it was determined that the neural network can learn the 4-input AND gate with a **minimum of 1 hidden neuron**. Training epochs for this configuration ranged between **1200 and 1900** based on an optimization function.

---

### Training Epochs Across Hidden Layers

Each configuration was optimized 5 times to compute the average number of training epochs required. Below is a table summarizing the results:

| Hidden Layers (y) | Attempt 1 | Attempt 2 | Attempt 3 | Attempt 4 | Attempt 5 | Average Epochs |
|--------------------|-----------|-----------|-----------|-----------|-----------|----------------|
| 1                  | 1842      | 1510      | 1631      | 1420      | 1596      | **1599.8**     |
| 50                 | 352       | 299       | 360       | 328       | 329       | **333.6**      |
| 100                | 160       | 141       | 155       | 232       | 119       | **161.4**      |
| 500                | 62        | 27        | 13        | 85        | 44        | **46.2**       |
| 1000               | 48        | 15        | 63        | 21        | 14        | **32.2**       |
| 1500               | 120       | 149       | 133       | 112       | 52        | **113.2**      |

**Note:** The experiment stopped at 1500 hidden layers due to hardware limitations.

### Conclusion
The **minimum number of training epochs** to achieve learning is **32 epochs**, observed with 1000 hidden layers.

---

## Screenshots

Insert screenshots of your application or results here to provide visual insights.
### Initial Launch
![image](https://github.com/user-attachments/assets/210495c3-c41b-436f-b5c0-f0268d00fce8)

### Got a true 
![image](https://github.com/user-attachments/assets/bbee5397-97ec-4035-936c-465555d55ace)

### Auto Optimize Button
![image](https://github.com/user-attachments/assets/1ce6492e-d263-4ad0-88d2-f637bc95f192)



---
