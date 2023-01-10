import pandas as pd

sr = pd.Series([17000, 18000, 1000, 5000],
               index=["피자", "치킨", "콜라", "맥주"])
print('시리즈 출력 :')
print('-'*15)
print(sr)
from nltk.tokenize import word_tokenize
from nltk.tokenize import WordPunctTokenizer
import nltk
# nltk.download('punkt')
print(word_tokenize("Don't be fooled by the dark sounding name, Mr. Jone's Orphanage is as cheery as cheery goes for a pastry shop."))
