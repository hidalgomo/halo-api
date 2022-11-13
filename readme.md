# HALO Api

## Description


## Metadata

Metadata is data utilized by the HALO application to perform specific processes. Metadata is retrieved in a predetermined, specified order. The metadata is accumulated according to its purpose and stored in an array. The last element of this array holds information for each metadata index. The below example is 

```json
{
    data: [
        [...metaData1],
        [...metaData2],
        [...metaData3],
        [metaTitle1, metaTitle2, metaTitle3]
    ]
}
```