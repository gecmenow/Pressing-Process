# Do not delete the following import lines
from abaqus import *
from abaqusConstants import *
import __main__

def Macro1():
    import section
    import regionToolset
    import displayGroupMdbToolset as dgm
    import part
    import material
    import assembly
    import step
    import interaction
    import load
    import mesh
    import optimization
    import job
    import sketch
    import visualization
    import xyPlot
    import displayGroupOdbToolset as dgo
    import connectorBehavior
    iges = mdb.openIges('@BlankFolder', msbo=False, 
        trimCurve=DEFAULT, scaleFromFile=OFF)
    mdb.models['Model-1'].PartFromGeometryFile(name='Blank_1', geometryFile=iges, 
        combine=False, stitchAfterCombine=False, stitchTolerance=1.0, 
        dimensionality=THREE_D, type=DEFORMABLE_BODY, convertToAnalytical=1, 
        stitchEdges=1)
    p = mdb.models['Model-1'].parts['Blank_1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    iges = mdb.openIges('@BlankFolder', msbo=False, 
        trimCurve=DEFAULT, scaleFromFile=OFF)
    mdb.models['Model-1'].PartFromGeometryFile(name='Blank_2', geometryFile=iges, 
        combine=False, stitchAfterCombine=False, stitchTolerance=1.0, 
        dimensionality=THREE_D, type=DEFORMABLE_BODY, convertToAnalytical=1, 
        stitchEdges=1)
    p = mdb.models['Model-1'].parts['Blank_2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    iges = mdb.openIges('@PlatformFolder', msbo=False, 
        trimCurve=DEFAULT, topology=SHELL, scaleFromFile=OFF)
    mdb.models['Model-1'].PartFromGeometryFile(name='Platform', geometryFile=iges, 
        combine=False, stitchAfterCombine=False, stitchTolerance=1.0, 
        dimensionality=THREE_D, type=DISCRETE_RIGID_SURFACE, topology=SHELL, 
        convertToAnalytical=1, stitchEdges=1)
    p = mdb.models['Model-1'].parts['Platform']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    iges = mdb.openIges('@Ring1Folder', msbo=False, 
        trimCurve=DEFAULT, scaleFromFile=OFF)
    mdb.models['Model-1'].PartFromGeometryFile(name='Ring1', geometryFile=iges, 
        combine=False, stitchAfterCombine=False, stitchTolerance=1.0, 
        dimensionality=THREE_D, type=DEFORMABLE_BODY, convertToAnalytical=1, 
        stitchEdges=1)
    p = mdb.models['Model-1'].parts['Ring1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    iges = mdb.openIges('@Ring2Folder', msbo=False, 
        trimCurve=DEFAULT, scaleFromFile=OFF)
    mdb.models['Model-1'].PartFromGeometryFile(name='Ring2', geometryFile=iges, 
        combine=False, stitchAfterCombine=False, stitchTolerance=1.0, 
        dimensionality=THREE_D, type=DEFORMABLE_BODY, convertToAnalytical=1, 
        stitchEdges=1)
    p = mdb.models['Model-1'].parts['Ring2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    iges = mdb.openIges('@StampFolder', msbo=False, 
        trimCurve=DEFAULT, scaleFromFile=OFF)
    mdb.models['Model-1'].PartFromGeometryFile(name='Stamp', geometryFile=iges, 
        combine=False, stitchAfterCombine=False, stitchTolerance=1.0, 
        dimensionality=THREE_D, type=DEFORMABLE_BODY, convertToAnalytical=1, 
        stitchEdges=1)
    p = mdb.models['Model-1'].parts['Stamp']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    session.viewports['Viewport: 1'].partDisplay.setValues(sectionAssignments=ON, 
        engineeringFeatures=ON)
    session.viewports['Viewport: 1'].partDisplay.geometryOptions.setValues(
        referenceRepresentation=OFF)
    mdb.models['Model-1'].Material(name='BT-1')
    mdb.models['Model-1'].materials['BT-1'].Density(table=((4.5e-09, ), ))
    mdb.models['Model-1'].materials['BT-1'].Elastic(table=((112000.0, 0.32), ))
    mdb.models['Model-1'].materials['BT-1'].Plastic(table=((1.0, 0.0), (119.0, 
        0.020202707), (136.0, 0.199671195), (148.0, 0.400477567), (150.0, 
        0.599656837), (149.0, 0.798507696)))
    mdb.models['Model-1'].Material(name='M1')
    mdb.models['Model-1'].materials['M1'].Density(table=((8.89e-09, ), ))
    mdb.models['Model-1'].materials['M1'].Elastic(table=((125000.0, 0.35), ))
    mdb.models['Model-1'].materials['M1'].Plastic(table=((1.0, 0.0), (195.0, 
        0.010050336), (245.0, 0.105360516), (288.0, 0.223143551), (325.0, 
        0.356674944), (352.0, 0.510825624)))
    mdb.models['Model-1'].Material(name='XHM')
    mdb.models['Model-1'].materials['XHM'].Density(table=((4.5e-09, ), ))
    mdb.models['Model-1'].materials['XHM'].Elastic(table=((112000.0, 0.32), ))
    mdb.models['Model-1'].materials['XHM'].Plastic(table=((1.0, 0.0), (119.0, 
        0.020202707), (136.0, 0.199671195), (148.0, 0.400477567), (150.0, 
        0.599656837), (149.0, 0.798507696)))
    mdb.models['Model-1'].Material(name='MF1C')
    mdb.models['Model-1'].materials['MF1C'].Density(table=((4.5e-09, ), ))
    mdb.models['Model-1'].materials['MF1C'].Elastic(table=((112000.0, 0.32), ))
    mdb.models['Model-1'].materials['MF1C'].Plastic(table=((1.0, 0.0), (119.0, 
        0.020202707), (136.0, 0.199671195), (148.0, 0.400477567), (150.0, 
        0.599656837), (149.0, 0.798507696)))
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=ON)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=313.536, 
        farPlane=588.946, width=252.169, height=127.612, viewOffsetX=-9.14471, 
        viewOffsetY=22.2295)
    mdb.models['Model-1'].Material(name='XH')
    mdb.models['Model-1'].materials['XH'].Density(table=((4.5e-09, ), ))
    mdb.models['Model-1'].materials['XH'].Elastic(table=((112000.0, 0.32), ))
    mdb.models['Model-1'].materials['XH'].Plastic(table=((1.0, 0.0), (119.0, 
        0.020202707), (136.0, 0.199671195), (148.0, 0.400477567), (150.0, 
        0.599656837), (149.0, 0.798507696)))
    session.viewports['Viewport: 1'].view.setValues(nearPlane=311.588, 
        farPlane=590.894, width=266.599, height=134.914, viewOffsetX=-3.55712, 
        viewOffsetY=15.2128)
    p1 = mdb.models['Model-1'].parts['Blank_1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Blank_1']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    p.Set(cells=cells, name='Set-Blank_1')
    p = mdb.models['Model-1'].parts['Blank_1']
    s = p.faces
    side1Faces = s.getSequenceFromMask(mask=('[#f ]', ), )
    p.Surface(side1Faces=side1Faces, name='Surf-Blank_1')
    p1 = mdb.models['Model-1'].parts['Blank_2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Blank_2']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    p.Set(cells=cells, name='Set-Blank_2')
    p = mdb.models['Model-1'].parts['Blank_2']
    s = p.faces
    side1Faces = s.getSequenceFromMask(mask=('[#f ]', ), )
    p.Surface(side1Faces=side1Faces, name='Surf-Blank_2')
    p = mdb.models['Model-1'].parts['Platform']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Platform']
    p.ReferencePoint(point=(0.0, 0.0, 0.0))
    p = mdb.models['Model-1'].parts['Platform']
    r = p.referencePoints
    refPoints=(r[2], )
    p.Set(referencePoints=refPoints, name='Set-Platform')
    p = mdb.models['Model-1'].parts['Platform']
    s = p.faces
    side1Faces = s.getSequenceFromMask(mask=('[#f ]', ), )
    p.Surface(side1Faces=side1Faces, name='Surf-Platform')
    p1 = mdb.models['Model-1'].parts['Ring1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Ring1']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    p.Set(cells=cells, name='Set-Ring1')
    p = mdb.models['Model-1'].parts['Ring1']
    s = p.faces
    side1Faces = s.getSequenceFromMask(mask=('[#3f ]', ), )
    p.Surface(side1Faces=side1Faces, name='Surf-Ring1')
    p1 = mdb.models['Model-1'].parts['Ring2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Ring2']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    p.Set(cells=cells, name='Set-Ring2')
    p = mdb.models['Model-1'].parts['Ring2']
    s = p.faces
    side1Faces = s.getSequenceFromMask(mask=('[#3f ]', ), )
    p.Surface(side1Faces=side1Faces, name='Surf-Ring2')
    p1 = mdb.models['Model-1'].parts['Stamp']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Stamp']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    p.Set(cells=cells, name='Set-Stamp')
    p = mdb.models['Model-1'].parts['Stamp']
    s = p.faces
    side1Faces = s.getSequenceFromMask(mask=('[#ffffff ]', ), )
    p.Surface(side1Faces=side1Faces, name='Surf-Stamp')
    mdb.models['Model-1'].HomogeneousSolidSection(name='BT1', material='BT-1', 
        thickness=None)
    mdb.models['Model-1'].HomogeneousSolidSection(name='M1', material='M1', 
        thickness=None)
    mdb.models['Model-1'].HomogeneousSolidSection(name='XHM', material='XHM', 
        thickness=None)
    mdb.models['Model-1'].HomogeneousSolidSection(name='MF1C', material='MF1C', 
        thickness=None)
    mdb.models['Model-1'].HomogeneousSolidSection(name='XH', material='XH', 
        thickness=None)
    p1 = mdb.models['Model-1'].parts['Blank_1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Blank_1']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    region = regionToolset.Region(cells=cells)
    p = mdb.models['Model-1'].parts['Blank_1']
    p.SectionAssignment(region=region, sectionName='BT1', offset=0.0, 
        offsetType=MIDDLE_SURFACE, offsetField='', 
        thicknessAssignment=FROM_SECTION)
    p1 = mdb.models['Model-1'].parts['Blank_2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Blank_2']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    region = regionToolset.Region(cells=cells)
    p = mdb.models['Model-1'].parts['Blank_2']
    p.SectionAssignment(region=region, sectionName='M1', offset=0.0, 
        offsetType=MIDDLE_SURFACE, offsetField='', 
        thicknessAssignment=FROM_SECTION)
    p1 = mdb.models['Model-1'].parts['Stamp']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    p = mdb.models['Model-1'].parts['Stamp']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    region = regionToolset.Region(cells=cells)
    p = mdb.models['Model-1'].parts['Stamp']
    p.SectionAssignment(region=region, sectionName='XHM', offset=0.0, 
        offsetType=MIDDLE_SURFACE, offsetField='', 
        thicknessAssignment=FROM_SECTION)
    p = mdb.models['Model-1'].parts['Ring1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Ring2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=ON)
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=OFF)
    p = mdb.models['Model-1'].parts['Ring1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=ON)
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=OFF)
    p = mdb.models['Model-1'].parts['Ring1']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    region = regionToolset.Region(cells=cells)
    p = mdb.models['Model-1'].parts['Ring1']
    p.SectionAssignment(region=region, sectionName='XH', offset=0.0, 
        offsetType=MIDDLE_SURFACE, offsetField='', 
        thicknessAssignment=FROM_SECTION)
    p1 = mdb.models['Model-1'].parts['Ring2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p1)
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=ON)
    session.viewports['Viewport: 1'].partDisplay.setValues(viewCut=OFF)
    p = mdb.models['Model-1'].parts['Ring2']
    c = p.cells
    cells = c.getSequenceFromMask(mask=('[#1 ]', ), )
    region = regionToolset.Region(cells=cells)
    p = mdb.models['Model-1'].parts['Ring2']
    p.SectionAssignment(region=region, sectionName='MF1C', offset=0.0, 
        offsetType=MIDDLE_SURFACE, offsetField='', 
        thicknessAssignment=FROM_SECTION)
    a = mdb.models['Model-1'].rootAssembly
    session.viewports['Viewport: 1'].setValues(displayedObject=a)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(
        adaptiveMeshConstraints=ON, optimizationTasks=OFF, 
        geometricRestrictions=OFF, stopConditions=OFF)
    mdb.models['Model-1'].ExplicitDynamicsStep(name='Step-1', 
        previous='Initial', timePeriod=0.05)
    mdb.models['Model-1'].fieldOutputRequests['F-Output-1'].setValues(variables=('SVAVG', 'PEVAVG', 'PEEQVAVG', 'U', 'V', 'A', 'RF', 'CSTRESS', 'EVF'))
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(step='Step-1')
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(
        adaptiveMeshConstraints=OFF)
    a = mdb.models['Model-1'].rootAssembly
    a.DatumCsysByDefault(CARTESIAN)
    p = mdb.models['Model-1'].parts['Blank_1']
    a.Instance(name='Blank_1-1', part=p, dependent=ON)
    p = mdb.models['Model-1'].parts['Blank_2']
    a.Instance(name='Blank_2-1', part=p, dependent=ON)
    p = mdb.models['Model-1'].parts['Platform']
    a.Instance(name='Platform-1', part=p, dependent=ON)
    p = mdb.models['Model-1'].parts['Ring1']
    a.Instance(name='Ring1-1', part=p, dependent=ON)
    p = mdb.models['Model-1'].parts['Ring2']
    a.Instance(name='Ring2-1', part=p, dependent=ON)
    p = mdb.models['Model-1'].parts['Stamp']
    a.Instance(name='Stamp-1', part=p, dependent=ON)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=380.216, 
        farPlane=630.847, width=331.69, height=167.854, cameraPosition=(498.53, 
        161.534, -49.2146), cameraUpVector=(-0.130461, 0.990457, 0.0444374), 
        cameraTarget=(-0.000553131, 93.6602, 2.86102e-006))
    session.viewports['Viewport: 1'].view.setValues(nearPlane=391.851, 
        farPlane=619.211, width=341.84, height=172.99, cameraPosition=(499.379, 
        72.9336, -75.8451), cameraUpVector=(0.0409531, 0.999155, -0.00340412), 
        cameraTarget=(-0.000553131, 93.6601, -2.14577e-005))
    session.viewports['Viewport: 1'].view.setValues(nearPlane=417.513, 
        farPlane=593.55, width=119.584, height=60.5165, viewOffsetX=1.12187, 
        viewOffsetY=15.8247)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=421.651, 
        farPlane=592.222, width=120.769, height=61.1162, cameraPosition=(
        502.442, 110.773, -65.143), cameraUpVector=(-0.029711, 0.998953, 
        0.0347745), cameraTarget=(1.32412, 93.6261, -0.728071), 
        viewOffsetX=1.13299, viewOffsetY=15.9815)
    a = mdb.models['Model-1'].rootAssembly
    a.translate(instanceList=('Blank_1-1', ), vector=(0.0, @GoodBlankPosition, 0.0))
    session.viewports['Viewport: 1'].view.setValues(nearPlane=405.286, 
        farPlane=608.587, width=264.984, height=134.097, viewOffsetX=-12.3825, 
        viewOffsetY=57.9143)
    a = mdb.models['Model-1'].rootAssembly
    a.translate(instanceList=('Blank_2-1', ), vector=(0.0, @BadBlankPosition, 0.0))
    session.viewports['Viewport: 1'].view.setValues(nearPlane=419.287, 
        farPlane=594.586, width=130.468, height=66.0242, viewOffsetX=0.962797, 
        viewOffsetY=58.545)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=404.066, 
        farPlane=634.274, width=125.732, height=63.6274, cameraPosition=(
        449.284, 199.712, -237.563), cameraUpVector=(-0.182562, 0.978461, 
        0.0963551), cameraTarget=(12.3611, 95.3552, -5.67792), 
        viewOffsetX=0.927846, viewOffsetY=56.4197)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=414.811, 
        farPlane=623.53, width=42.3785, height=21.446, viewOffsetX=0.640576, 
        viewOffsetY=59.6187)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=427.764, 
        farPlane=611.386, width=43.7018, height=22.1156, cameraPosition=(
        503.116, 197.234, -78.3123), cameraUpVector=(-0.198188, 0.979412, 
        0.0383896), cameraTarget=(14.6734, 95.2166, 2.7975), 
        viewOffsetX=0.660579, viewOffsetY=61.4803)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=424.68, 
        farPlane=614.47, width=71.1761, height=36.0192, viewOffsetX=0.117655, 
        viewOffsetY=62.299)
    a = mdb.models['Model-1'].rootAssembly
    a.translate(instanceList=('Platform-1', ), vector=(0.0, @PlatformPosition, 0.0))
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(interactions=ON, 
        constraints=ON, connectors=ON, engineeringFeatures=ON)
    mdb.models['Model-1'].ContactProperty('IntProp-1')
    mdb.models['Model-1'].interactionProperties['IntProp-1'].TangentialBehavior(
        formulation=PENALTY, directionality=ISOTROPIC, slipRateDependency=OFF, 
        pressureDependency=OFF, temperatureDependency=OFF, dependencies=0, 
        table=((0.2, ), ), shearStressLimit=None, maximumElasticSlip=FRACTION, 
        fraction=0.005, elasticSlipStiffness=None)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(step='Step-1')
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(interactions=OFF, 
        constraints=OFF, connectors=OFF, engineeringFeatures=OFF, 
        adaptiveMeshConstraints=ON)
    session.viewports['Viewport: 1'].view.setValues(nearPlane=395.797, 
        farPlane=643.353, width=281.138, height=142.272, viewOffsetX=11.5336, 
        viewOffsetY=36.5701)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(interactions=ON, 
        constraints=ON, connectors=ON, engineeringFeatures=ON, 
        adaptiveMeshConstraints=OFF)
    a = mdb.models['Model-1'].rootAssembly
    region1=a.instances['Platform-1'].surfaces['Surf-Platform']
    a = mdb.models['Model-1'].rootAssembly
    region2=a.instances['Blank_2-1'].surfaces['Surf-Blank_2']
    mdb.models['Model-1'].SurfaceToSurfaceContactExp(name ='Int-1', 
        createStepName='Step-1', master = region1, slave = region2, 
        mechanicalConstraint=KINEMATIC, sliding=FINITE, 
        interactionProperty='IntProp-1', initialClearance=OMIT, datumAxis=None, 
        clearanceRegion=None)
    a = mdb.models['Model-1'].rootAssembly
    region1=a.instances['Stamp-1'].surfaces['Surf-Stamp']
    a = mdb.models['Model-1'].rootAssembly
    region2=a.instances['Blank_2-1'].surfaces['Surf-Blank_2']
    mdb.models['Model-1'].SurfaceToSurfaceContactExp(name ='Int-2', 
        createStepName='Step-1', master = region1, slave = region2, 
        mechanicalConstraint=KINEMATIC, sliding=FINITE, 
        interactionProperty='IntProp-1', initialClearance=OMIT, datumAxis=None, 
        clearanceRegion=None)

    a = mdb.models['Model-1'].rootAssembly
    region1=a.instances['Blank_1-1'].surfaces['Surf-Blank_1']
    a = mdb.models['Model-1'].rootAssembly
    region2=a.instances['Blank_2-1'].surfaces['Surf-Blank_2']
    mdb.models['Model-1'].SurfaceToSurfaceContactExp(name ='Int-6', 
        createStepName='Step-1', master = region1, slave = region2, 
        mechanicalConstraint=KINEMATIC, sliding=FINITE, 
        interactionProperty='IntProp-1', initialClearance=OMIT, datumAxis=None, 
        clearanceRegion=None)

    a = mdb.models['Model-1'].rootAssembly
    region1=a.instances['Stamp-1'].surfaces['Surf-Stamp']
    a = mdb.models['Model-1'].rootAssembly
    region2=a.instances['Blank_1-1'].surfaces['Surf-Blank_1']
    mdb.models['Model-1'].SurfaceToSurfaceContactExp(name ='Int-3', 
        createStepName='Step-1', master = region1, slave = region2, 
        mechanicalConstraint=KINEMATIC, sliding=FINITE, 
        interactionProperty='IntProp-1', initialClearance=OMIT, datumAxis=None, 
        clearanceRegion=None)
    a = mdb.models['Model-1'].rootAssembly
    region1=a.instances['Stamp-1'].surfaces['Surf-Stamp']
    a = mdb.models['Model-1'].rootAssembly
    region2=a.instances['Ring1-1'].surfaces['Surf-Ring1']
    mdb.models['Model-1'].SurfaceToSurfaceContactExp(name ='Int-4', 
        createStepName='Step-1', master = region1, slave = region2, 
        mechanicalConstraint=KINEMATIC, sliding=FINITE, 
        interactionProperty='IntProp-1', initialClearance=OMIT, datumAxis=None, 
        clearanceRegion=None)
    a = mdb.models['Model-1'].rootAssembly
    region1=a.instances['Stamp-1'].surfaces['Surf-Stamp']
    a = mdb.models['Model-1'].rootAssembly
    region2=a.instances['Ring2-1'].surfaces['Surf-Ring2']
    mdb.models['Model-1'].SurfaceToSurfaceContactExp(name ='Int-5', 
        createStepName='Step-1', master = region1, slave = region2, 
        mechanicalConstraint=KINEMATIC, sliding=FINITE, 
        interactionProperty='IntProp-1', initialClearance=OMIT, datumAxis=None, 
        clearanceRegion=None)
    mdb.models['Model-1'].TabularAmplitude(name='Amp-1', timeSpan=STEP, 
        smooth=SOLVER_DEFAULT, data=((0.0, 0.0), (1.0, 1.0)))
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(loads=ON, bcs=ON, 
        predefinedFields=ON, interactions=OFF, constraints=OFF, 
        engineeringFeatures=OFF)
    a = mdb.models['Model-1'].rootAssembly
    region = a.instances['Platform-1'].sets['Set-Platform']
    mdb.models['Model-1'].DisplacementBC(name='BC-1', createStepName='Step-1', 
        region=region, u1=0.0, u2=UNSET, u3=0.0, ur1=0.0, ur2=0.0, ur3=0.0, 
        amplitude='Amp-1', fixed=OFF, distributionType=UNIFORM, fieldName='', 
        localCsys=None)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(mesh=ON, loads=OFF, 
        bcs=OFF, predefinedFields=OFF, connectors=OFF)
    session.viewports['Viewport: 1'].assemblyDisplay.meshOptions.setValues(
        meshTechnique=ON)
    p = mdb.models['Model-1'].parts['Blank_1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    session.viewports['Viewport: 1'].partDisplay.setValues(mesh=ON)
    session.viewports['Viewport: 1'].partDisplay.meshOptions.setValues(
        meshTechnique=ON)
    session.viewports['Viewport: 1'].partDisplay.geometryOptions.setValues(
        referenceRepresentation=OFF)
    p = mdb.models['Model-1'].parts['Blank_1']
    p.seedPart(size=7.0, deviationFactor=0.1, minSizeFactor=0.1)
    p = mdb.models['Model-1'].parts['Blank_1']
    p.generateMesh()
    p = mdb.models['Model-1'].parts['Blank_2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Blank_2']
    p.seedPart(size=7.0, deviationFactor=0.1, minSizeFactor=0.1)
    p = mdb.models['Model-1'].parts['Blank_2']
    p.generateMesh()
    p = mdb.models['Model-1'].parts['Platform']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Platform']
    p.seedPart(size=20.0, deviationFactor=0.1, minSizeFactor=0.1)
    p = mdb.models['Model-1'].parts['Platform']
    p.generateMesh()
    p = mdb.models['Model-1'].parts['Ring1']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Ring1']
    p.seedPart(size=15.0, deviationFactor=0.1, minSizeFactor=0.1)
    p = mdb.models['Model-1'].parts['Ring1']
    p.generateMesh()
    p = mdb.models['Model-1'].parts['Ring2']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Ring2']
    p.seedPart(size=15.0, deviationFactor=0.1, minSizeFactor=0.1)
    p = mdb.models['Model-1'].parts['Ring2']
    p.generateMesh()
    p = mdb.models['Model-1'].parts['Stamp']
    session.viewports['Viewport: 1'].setValues(displayedObject=p)
    p = mdb.models['Model-1'].parts['Stamp']
    p.seedPart(size=15.0, deviationFactor=0.1, minSizeFactor=0.1)
    p = mdb.models['Model-1'].parts['Stamp']
    p.generateMesh()
    a1 = mdb.models['Model-1'].rootAssembly
    a1.regenerate()
    a = mdb.models['Model-1'].rootAssembly
    session.viewports['Viewport: 1'].setValues(displayedObject=a)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(mesh=OFF)
    session.viewports['Viewport: 1'].assemblyDisplay.meshOptions.setValues(
        meshTechnique=OFF)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(loads=ON, bcs=ON, 
        predefinedFields=ON, connectors=ON)
    a = mdb.models['Model-1'].rootAssembly
    region = a.instances['Platform-1'].sets['Set-Platform']
    mdb.models['Model-1'].DisplacementBC(name='BC-2', createStepName='Step-1', 
        region=region, u1=UNSET, u2=-@Displacement, u3=UNSET, ur1=UNSET, ur2=UNSET, 
        ur3=UNSET, amplitude='Amp-1', fixed=OFF, distributionType=UNIFORM, 
        fieldName='', localCsys=None)
    a = mdb.models['Model-1'].rootAssembly
    region = a.instances['Stamp-1'].sets['Set-Stamp']
    mdb.models['Model-1'].DisplacementBC(name='BC-3', createStepName='Step-1', 
        region=region, u1=UNSET, u2=0.0, u3=UNSET, ur1=UNSET, ur2=UNSET, 
        ur3=UNSET, amplitude='Amp-1', fixed=OFF, distributionType=UNIFORM, 
        fieldName='', localCsys=None)
    a = mdb.models['Model-1'].rootAssembly
    region = a.instances['Ring2-1'].sets['Set-Ring2']
    mdb.models['Model-1'].DisplacementBC(name='BC-4', createStepName='Step-1', 
        region=region, u1=UNSET, u2=0.0, u3=UNSET, ur1=UNSET, ur2=UNSET, 
        ur3=UNSET, amplitude='Amp-1', fixed=OFF, distributionType=UNIFORM, 
        fieldName='', localCsys=None)
    a = mdb.models['Model-1'].rootAssembly
    region = a.instances['Ring1-1'].sets['Set-Ring1']
    mdb.models['Model-1'].DisplacementBC(name='BC-5', createStepName='Step-1', 
        region=region, u1=UNSET, u2=0.0, u3=UNSET, ur1=UNSET, ur2=UNSET, 
        ur3=UNSET, amplitude='Amp-1', fixed=OFF, distributionType=UNIFORM, 
        fieldName='', localCsys=None)
    regionDef=mdb.models['Model-1'].rootAssembly.instances['Stamp-1'].sets['Set-Stamp']
    mdb.models['Model-1'].FieldOutputRequest(name='F-Output-2', 
        createStepName='Step-1', variables=('S', 'LE'), region=regionDef, 
        sectionPoints=DEFAULT, rebar=EXCLUDE)
    regionDef=mdb.models['Model-1'].rootAssembly.instances['Blank_1-1'].sets['Set-Blank_1']
    mdb.models['Model-1'].FieldOutputRequest(name='F-Output-3', 
        createStepName='Step-1', variables=('PEEQ', ), region=regionDef, 
        sectionPoints=DEFAULT, rebar=EXCLUDE)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(loads=OFF, bcs=OFF, 
        predefinedFields=OFF, connectors=OFF)
    session.viewports['Viewport: 1'].assemblyDisplay.setValues(loads=OFF, bcs=OFF, 
        predefinedFields=OFF, connectors=OFF)
    mdb.saveAs(pathName='Job1.cae')
    mdb.Job(name='Job-1', model='Model-1', description='', type=ANALYSIS, 
        atTime=None, waitMinutes=0, waitHours=0, queue=None, 
        explicitPrecision=SINGLE, nodalOutputPrecision=SINGLE, echoPrint=OFF, 
        modelPrint=OFF, contactPrint=OFF, historyPrint=OFF, userSubroutine='', 
        scratch='', parallelizationMethodExplicit=DOMAIN, numDomains=2, 
        activateLoadBalancing=False, multiprocessingMode=DEFAULT, numCpus=2)
    mdb.jobs['Job-1'].submit(consistencyChecking=OFF)
Macro1()