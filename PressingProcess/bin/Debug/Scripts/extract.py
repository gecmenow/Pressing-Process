
from odbAccess import *

# Open the output database.
import os; 

filepath = 'Job-1.odb';
odb = openOdb(filepath)

SOutput = open('SOutput.csv','w')
LEOutput = open('LEOutput.csv','w')
PEEQOutput = open('PEEQOutput.csv','w')

assembly = odb.rootAssembly

lastFrame = odb.steps['Step-1'].frames[-1]

SOutput.write('Element;Value\n')
output=lastFrame.fieldOutputs['S']
for out in output.values:
	SOutput.write('%d;%6.4f\n' % (out.elementLabel, out.data[3]))

output=lastFrame.fieldOutputs['LE']
LEOutput.write('Element;Value\n')
for out in output.values:
	LEOutput.write('%d;%6.4f\n' % (out.elementLabel, out.data[3]))

output=lastFrame.fieldOutputs['PEEQ']
PEEQOutput.write('Element;Value\n')
for out in output.values:
	PEEQOutput.write('%d;%6.4f\n' % (out.elementLabel, out.data))
