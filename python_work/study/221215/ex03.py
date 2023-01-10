
import pandas as pd
import numpy as np
from tensorflow.keras.preprocessing.text import Tokenizer
from tensorflow.keras.utils import to_categorical
from tensorflow.keras.preprocessing.sequence import pad_sequences

import re

text = [["나는 좋아",0],["나는 싫어",1],["이건 좋아",0],["이건 싫어",1]]
mypd = pd.DataFrame(text,columns=["data","target"])

print(mypd)

data = np.array(mypd["data"].to_numpy()).reshape(-1,1)
print(data)
target = np.array(mypd["target"].to_numpy())
print(target)
text = re.sub(r'\W','',f"{data.reshape(-1)}")
print(text)
text = re.sub(r'\,||\'||\[||\]','',f"{data.reshape(-1)}")
print(text)
tokenizer = Tokenizer()
tokenizer.fit_on_texts([text])
print('단어 집합 :',tokenizer.word_index)

encodeds = []
for i in data:
    print(i)
    encoded = tokenizer.texts_to_sequences(i)[0]
    print(encoded)
    pad_sequences(encoded)
    encodeds.append(encoded)

print(encodeds)

from sklearn.neighbors import KNeighborsClassifier
knc = KNeighborsClassifier()
knc.fit(encodeds,target)

encoded = tokenizer.texts_to_sequences(['좋아'])[0]
pa_encoded = pad_sequences(encoded)
print(pa_encoded)
print(pa_encoded)